Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Text

Public Class Terminal
    Dim myPort As Array
    Dim prcRow As Integer = 0
    Dim prcCount(5) As Integer
    Dim prcProcessCount As Integer
    Dim SpChar As Boolean = False
    Dim rtxOutCnt As Integer
    Dim comBuffer As Byte()
    Dim prcBuffer(5, 1024) As Byte
    Dim screen0Cnt As Integer
    Private Delegate Sub UpdateFormDelegate(ByRef buff As Byte(), ByVal Count As Integer)
    Dim UpdateformDelegate1 As UpdateFormDelegate
    Dim SetFormVisible As Boolean = False
    Dim BankFormVisible As Boolean = False
    Dim ScreenFormVisible As Boolean = False
    Dim PercentFormVisible As Boolean = False
    Dim OffOnFormVisible As Boolean = False
    Dim RxHistFormVisible As Boolean = False
    Dim BandFormVisible As Boolean = False
    Dim TerminalVisible As Boolean = True

    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myPort)
        'CmbPort.Text = "COM9"
        Screen.lblLock.Visible = False
        prcRow = 0
        prcProcessCount = 0

        'BtnInit_Click(sender, e)

        For i = 0 To 5
            prcCount(i) = 0
        Next
        Screen.Show()
        ScreenFormVisible = True
    End Sub

    Private Sub Terminal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
    End Sub

    Private Sub BtnInit_Click(sender As Object, e As EventArgs) Handles BtnInit.Click
        RtxOutput.Text = ""
        rtxOutCnt = 0
        SerialPort.PortName = CmbPort.Text
        SerialPort.BaudRate = 38400
        SerialPort.DataBits = 8
        SerialPort.StopBits = StopBits.One
        SerialPort.Parity = Parity.None
        SerialPort.Handshake = Handshake.None
        SerialPort.Open()

        AddHandler SerialPort.DataReceived, AddressOf SerialPort_DataReceived

        BtnInit.Enabled = False
        'BtnWrite.Enabled = True
        BtnClose.Enabled = True
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        SerialPort.Close()
        BtnInit.Enabled = True
        'BtnWrite.Enabled = False
        BtnClose.Enabled = False
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'Handles SerialPort Data Received Events
        Dim Count As Integer = 0

        UpdateformDelegate1 = New UpdateFormDelegate(AddressOf UpdateDisplay)
        Count = SerialPort.BytesToRead  'We wouldn't be here if = 0
        comBuffer = New Byte(Count) {}  'Re dimension comBuffer
        SerialPort.Read(comBuffer, 0, Count)
        Me.Invoke(UpdateformDelegate1, comBuffer, Count)  'Call UpdateDisplay() from this thread
    End Sub

    Private Sub UpdateDisplay(ByRef buffer As Byte(), ByVal Count As Integer)
        Dim value As Integer
        Dim i As Integer
        Dim EndSW As Boolean = False

        For i = 0 To Count - 1
            value = buffer(i)
            'If (value >= &HF0) And (value <= &HFC) Then
            'Continue For
            'End If
            If value = &HFD Then
                EndSW = True
            End If
            If SpChar Then
                Select Case value
                    Case &HF
                        value = &HFF
                    Case &HE
                        value = &HFE
                    Case &HD
                        value = &HFD
                    Case Else
                        value = 0
                End Select
                SpChar = False
                Continue For
            End If
            If value = &HFF Then
                SpChar = True
                Continue For
            End If
            If btnCapture.BackColor = Color.LightGreen Then
                displayHex(value)   'Display on output screen in hex
            End If
            prcBuffer(prcRow, prcCount(prcRow)) = CByte(value)
            If EndSW Then
                EndSW = False
                prcRow += 1
                If prcRow > 5 Then prcRow = 0
                If prcRow = prcProcessCount Then
                    Stop
                End If
                ProcessLine()
                prcProcessCount += 1
                If prcProcessCount > 5 Then prcProcessCount = 0
                prcCount(prcProcessCount) = 0
            Else
                prcCount(prcProcessCount) += 1
            End If
        Next
    End Sub

    Private Sub displayHex(ByVal value As Integer)
        Dim temp As String
        If rtxOutCnt < 8192 Then
            temp = ""
            If value < 16 Then  'If < 16, add a zero
                temp &= "0" & Format(value, "X")  'Put out hex digit
            Else
                temp &= Format(value, "X")    '>= 16, put out two hex digits
            End If
            If value >= 32 And value < 128 Then 'Put out ASCII character
                temp &= Chr(value)
            Else
                temp &= " "   'If not ASCII, put out space
            End If
            temp &= " "   'Space between bytes
            If value = &HFD Then
                temp &= vbCr  'End of line, put out Carriage Return
            End If
            RtxOutput.Text &= temp
            rtxOutCnt = rtxOutCnt + Len(temp)
        End If
    End Sub

    Private Sub displayRecord()
        Dim i As Integer
        RtxOutput.Text = ""
        rtxOutCnt = 0
        For i = 0 To prcCount(prcProcessCount)
            displayHex(prcBuffer(prcProcessCount, i))
        Next
    End Sub

    Private Sub displayScreen0()
        Dim i As Integer
        RtxOutput.Text = ""
        rtxOutCnt = 0
        For i = 0 To &HFF
            displayHex(screen0(i))
        Next
    End Sub

    Private Sub displayScreen1()
        Dim i As Integer
        RtxOutput.Text = ""
        rtxOutCnt = 0
        For i = 0 To &HFF
            displayHex(screen1(i))
        Next
    End Sub

    Private Sub ProcessLine()
        Select Case prcBuffer(prcProcessCount, 1)
            Case 0
                If prcBuffer(prcProcessCount, 2) <> 0 Then
                    ProcessScreen0()
                End If
            Case 1
                ProcessScreen1()
            Case 2
                processscreen2()
            Case 3
                Return
            Case Else
                Return
                Stop
        End Select
    End Sub

    Private Sub ProcessScreen0()
        Dim i As Integer

        For i = 3 To prcCount(prcProcessCount) - 1
            screen0(prcBuffer(prcProcessCount, 2) + i) = prcBuffer(prcProcessCount, i)
        Next i

        ProcessScreen0sub1()
    End Sub

    Private Sub ProcessScreen0sub1()
        Select Case screen0(&H4) And &HC0
            Case &H0
                Screen.rtxXmitLed.BackColor = Color.White
            Case &H40
                Screen.rtxXmitLed.BackColor = Color.Red
            Case &H80
                Screen.rtxXmitLed.BackColor = Color.LightGreen
        End Select
        If (screen0(&H4) And &H20) <> 0 Then
            Screen.rtxPBT.BackColor = Color.LightGreen
        Else
            Screen.rtxPBT.BackColor = Color.White
        End If
        Select Case screen0(&HD)
            Case &H1
                NormalScreen()
            Case &H2
                DRScreen()
            Case &H4
                BandScreen()
            Case &H5
                SetScreen()
            Case &H7
                OffOnScreen()
            Case &HD
                PercentScreen()
            Case &H13
                RXHistScreen()
        End Select
    End Sub
    Private Sub ProcessScreen1()
        Dim i As Integer

        For i = 3 To prcCount(prcProcessCount) - 1
            screen1(prcBuffer(prcProcessCount, 2) + i) = prcBuffer(prcProcessCount, i)
        Next i
        SetForm.Display()
    End Sub

    Private Sub ProcessScreen2()
        Dim i As Integer

        For i = 3 To prcCount(prcProcessCount) - 1
            screen2(prcBuffer(prcProcessCount, 2) + i) = prcBuffer(prcProcessCount, i)
        Next i
        SetForm.Display()
    End Sub

    Private Sub NormalScreen()
        Dim Temp As String

        If SetFormVisible Then
            SetForm.Hide()
            SetFormVisible = False
        End If
        If PercentFormVisible Then
            PercentForm.Hide()
            PercentFormVisible = False
        End If
        If OffOnFormVisible Then
            SelectForm.Hide()
            OffOnFormVisible = False
        End If
        If RxHistFormVisible Then
            RxHistForm.Hide()
            RxHistFormVisible = False
        End If
        If BandFormVisible Then
            BandForm.Hide()
            BandFormVisible = False
        End If
        If Not ScreenFormVisible Then
            Screen.Show()
            ScreenFormVisible = True
        End If
        Select Case screen0(&H2A) And &H6
            Case &H2
                Screen.lblSD.Text = "SD"
            Case &H4
                Screen.lblSD.Text = "SD"
            Case Else
                Screen.lblSD.Text = ""
        End Select
        Select Case screen0(&H2C)
            Case &H1
                Screen.lblPreAmp.Text = "P.AMP"
                Screen.lblPreAmp.Visible = True
            Case &H2
                Screen.lblPreAmp.Text = "P.AMP1"
                Screen.lblPreAmp.Visible = True
            Case &H3
                Screen.lblPreAmp.Text = "P.AMP2"
                Screen.lblPreAmp.Visible = True
            Case Else
                Screen.lblPreAmp.Visible = False
        End Select
        If (screen0(&H2C) And &H4) <> 0 Then
            Screen.lblATT.Visible = True
        Else
            Screen.lblATT.Visible = False
        End If
        If (screen0(&H2C) And &H8) <> 0 Then
            Screen.lblVOX.Visible = True
        Else
            Screen.lblVOX.Visible = False
        End If
        If (screen0(&H2C) And &H20) <> 0 Then
            Screen.lblLock.Visible = True
        Else
            Screen.lblLock.Visible = False
        End If
        Select Case screen0(&H2D) And &H60
            Case &H20
                Screen.lblAGC.Text = "AGC-S"
            Case &H40
                Screen.lblAGC.Text = "AGC-M"
            Case &H60
                Screen.lblAGC.Text = "AGC-F"
            Case Else
                Screen.lblAGC.Text = ""
        End Select
        Select Case screen0(&H34) And &H7
            Case 1
                Screen.lblMulti.Text = "Power"
            Case 2
                Screen.lblMulti.Text = "SWR"
            Case 3
                Screen.lblMulti.Text = "ALC"
            Case 4
                Screen.lblMulti.Text = "Comp"
            Case Else
                Screen.lblMulti.Text = ""
        End Select
        If (screen0(&H34) And &H40) = &H40 Then
            Screen.rtxNB.Visible = True
        Else
            Screen.rtxNB.Visible = False
        End If
        If (screen0(&H34) And &H20) = &H20 Then
            Screen.rtxNR.Visible = True
        Else
            Screen.rtxNR.Visible = False
        End If
        If (screen0(&H34) And &H8) = &H8 Then
            Screen.rtxMN.Text = "    AN"
            Screen.rtxMN.Visible = True
        ElseIf (screen0(&H34) And &H10) = &H10 Then
            Screen.rtxMN.Text = "    MN"
            Screen.rtxMN.Visible = True
        Else
            Screen.rtxMN.Visible = False
        End If
        If screen0(&H35) <= 50 Then
            Screen.pgbSMeter.Value = screen0(&H35)
        Else
            Screen.pgbSMeter.Value = 50
        End If
        Temp = ClockDigit(screen0(&H38))
        Temp &= ClockDigit(screen0(&H39))
        Temp &= ":"
        Temp &= ClockDigit(screen0(&H3A))
        Screen.lblClock.Text = Temp & ClockDigit(screen0(&H3B))
        Select Case screen0(&H3D)
            Case &H23
                Screen.lblTone.Text = "TONE"
            Case &H43
                Screen.lblTone.Text = "TSQL"
            Case &H63
                Screen.lblTone.Text = "DTCS"
            Case Else
                Screen.lblTone.Text = "    "
        End Select
        Select Case screen0(&H3E) And &H38
            Case &H28
                Screen.lblDUP.Text = "DUP-"
            Case &H30
                Screen.lblDUP.Text = "DUP+"
            Case Else
                Screen.lblDUP.Text = ""
        End Select
        Select Case screen0(&H3E) And &H60
            Case &H20
                Screen.btnVFO.Text = "VFOA"
            Case &H40
                Screen.btnVFO.Text = "VFOB"
            Case &H60
                Screen.btnVFO.Text = "MEMO"
            Case Else
                Screen.btnVFO.Text = ""
        End Select
        Select Case screen0(&H3E) And &HE
            Case &H8
                Screen.lblSPChannel.Text = "*"
            Case &H4
                Screen.lblSPChannel.Text = "430"
            Case &H2
                Screen.lblSPChannel.Text = "144"
            Case &H0
                Select Case screen0(&H3D) And &H7
                    Case &H4
                        Screen.lblSPChannel.Text = "Blank"
                    Case &H1
                        Screen.lblSPChannel.Text = ""
                End Select
            Case Else
                Screen.lblSPChannel.Text = ""
        End Select
        Screen.lblchannel.Text = Encoding.ASCII.GetString(screen0, &H3F, 3)
        Screen.lblName.Text = Encoding.ASCII.GetString(screen0, &H42, 17)
        Select Case screen0(&H54) And &HF8
            Case &H98
                Screen.btnFilter.Text = "Fil1"
            Case &HA8
                Screen.btnFilter.Text = "Fil2"
            Case &HB8
                Screen.btnFilter.Text = "Fil3"
            Case &HC8
                Screen.btnFilter.Text = "Fil"
            Case Else
                Screen.btnFilter.Text = ""
        End Select
        If (screen0(&H54) And &H1) <> 0 Then
            Screen.lblSplit.Visible = True
        Else
            Screen.lblSplit.Visible = False
        End If
        Select Case screen0(&H57)
            Case &H84
                If (screen0(&H58) And &H80) = &H0 Then
                    Screen.btnMode.Text = "LSB"
                Else
                    Screen.btnMode.Text = "LSB-D"
                End If
            Case &H88
                If (screen0(&H58) And &H80) = &H0 Then
                    Screen.btnMode.Text = "USB"
                Else
                    Screen.btnMode.Text = "USB-D"
                End If
            Case &H8C
                Screen.btnMode.Text = "CW"
            Case &H94
                Screen.btnMode.Text = "RTTY"
            Case &H9C
                If (screen0(&H58) And &H80) = &H0 Then
                    Screen.btnMode.Text = "AM"
                Else
                    Screen.btnMode.Text = "AM-D"
                End If
            Case &HA0
                If (screen0(&H58) And &H80) = &H0 Then
                    Screen.btnMode.Text = "FM"
                Else
                    Screen.btnMode.Text = "FM-D"
                End If
            Case &HA4
                Screen.btnMode.Text = "WFM"
            Case Else
                Screen.btnMode.Text = ""
        End Select
        If (screen0(&H58) And &H40) = &H0 Then
            Screen.lblMark.Visible = False
        Else
            Screen.lblMark.Visible = True
        End If
        If screen0(&H59) = 0 Then
            If screen0(&H5C) <> &H0 And screen0(&H5C) <> &H20 Then
                Screen.lblFreq.Text = Encoding.ASCII.GetString(screen0, &H5A, 3)
                Screen.lblFreq.Text &= "."
                Screen.lblFreq.Text &= Encoding.ASCII.GetString(screen0, &H5D, 3)
                Screen.lblFreq.Text &= "."
                Screen.lblFreq.Text &= Encoding.ASCII.GetString(screen0, &H60, 2)
            Else
                Screen.lblFreq.Text = ""
            End If
        Else
            Screen.lblFreq.Text = ""
        End If
        Screen.btnButton1.Text = Encoding.ASCII.GetString(screen0, &H81, 5)
        Screen.btnButton2.Text = Encoding.ASCII.GetString(screen0, &H86, 5)
        Screen.btnButton3.Text = Encoding.ASCII.GetString(screen0, &H8B, 5)
        Screen.btnButton4.Text = Encoding.ASCII.GetString(screen0, &H90, 5)
        Screen.btnButton5.Text = Encoding.ASCII.GetString(screen0, &H95, 5)
        Temp = Encoding.ASCII.GetString(screen0, &HA1, 19)
        For i = Len(Temp) To 1 Step -1
            If Mid(Temp, i, 1) = " " Then
                Continue For
            Else
                Screen.lblMenuType.Text = Mid(Temp, 1, i)
                Exit For
            End If
        Next
        If screen0(&HB5) = 0 Then
            If screen0(&HB8) <> &H0 And screen0(&HB8) <> &H20 Then
                Screen.lblXmitFreq.Text = Encoding.ASCII.GetString(screen0, &HB6, 3)
                Screen.lblXmitFreq.Text &= "."
                Screen.lblXmitFreq.Text &= Encoding.ASCII.GetString(screen0, &HB9, 3)
                Screen.lblXmitFreq.Text &= "."
                Screen.lblXmitFreq.Text &= Encoding.ASCII.GetString(screen0, &HBB, 2)
                Screen.lblMode.Text = Screen.btnMode.Text
            Else
                Screen.lblXmitFreq.Text = ""
            End If
        ElseIf screen0(&HB6) = &H20 Then
            Screen.lblXmitFreq.Text = Encoding.ASCII.GetString(screen0, &HB6, &H10)
        Else
            Screen.lblXmitFreq.Text = ""
        End If
        Screen.lblGPS.Visible = False
    End Sub
    Private Sub DRScreen()

    End Sub

    Private Sub BandScreen()
        If ScreenFormVisible Then
            Screen.Hide()
            ScreenFormVisible = False
        End If
        If PercentFormVisible Then
            PercentForm.Hide()
            PercentFormVisible = False
        End If
        If OffOnFormVisible Then
            SelectForm.Hide()
            OffOnFormVisible = False
        End If
        If RxHistFormVisible Then
            RxHistForm.Hide()
            RxHistFormVisible = False
        End If
        If SetFormVisible Then
            SetForm.Hide()
            SetFormVisible = False
        End If
        If Not BandFormVisible Then
            BandForm.Show()
            BandFormVisible = True
        End If
    End Sub

    Private Sub SetScreen()
        If ScreenFormVisible Then
            Screen.Hide()
            ScreenFormVisible = False
        End If
        If PercentFormVisible Then
            PercentForm.Hide()
            PercentFormVisible = False
        End If
        If OffOnFormVisible Then
            SelectForm.Hide()
            OffOnFormVisible = False
        End If
        If RxHistFormVisible Then
            RxHistForm.Hide()
            RxHistFormVisible = False
        End If
        If BandFormVisible Then
            BandForm.Hide()
            BandFormVisible = False
        End If
        If Not SetFormVisible Then
            SetForm.Show()
            SetFormVisible = True
        End If
        SetForm.Display()
    End Sub

    Private Sub PercentScreen()
        If ScreenFormVisible Then
            Screen.Hide()
            ScreenFormVisible = False
        End If
        If SetFormVisible Then
            SetForm.Hide()
            SetFormVisible = False
        End If
        If OffOnFormVisible Then
            SelectForm.Hide()
            OffOnFormVisible = False
        End If
        If RxHistFormVisible Then
            RxHistForm.Hide()
            RxHistFormVisible = False
        End If
        If BandFormVisible Then
            BandForm.Hide()
            BandFormVisible = False
        End If
        If Not PercentFormVisible Then
            PercentForm.Show()
            PercentFormVisible = True
        End If
        PercentForm.Display()
    End Sub

    Private Sub OffOnScreen()
        If ScreenFormVisible Then
            Screen.Hide()
            ScreenFormVisible = False
        End If
        If PercentFormVisible Then
            PercentForm.Hide()
            PercentFormVisible = False
        End If
        If SetFormVisible Then
            SetForm.Hide()
            SetFormVisible = False
        End If
        If RxHistFormVisible Then
            RxHistForm.Hide()
            RxHistFormVisible = False
        End If
        If BandFormVisible Then
            BandForm.Hide()
            BandFormVisible = False
        End If
        If Not OffOnFormVisible Then
            SelectForm.Show()
            OffOnFormVisible = True
        End If
        SelectForm.Display()
    End Sub

    Private Sub RxHistScreen()
        If ScreenFormVisible Then
            Screen.Hide()
            ScreenFormVisible = False
        End If
        If SetFormVisible Then
            SetForm.Hide()
            SetFormVisible = False
        End If
        If OffOnFormVisible Then
            SelectForm.Hide()
            OffOnFormVisible = False
        End If
        If PercentFormVisible Then
            PercentForm.Hide()
            PercentFormVisible = False
        End If
        If BandFormVisible Then
            BandForm.Hide()
            BandFormVisible = False
        End If
        If Not RxHistFormVisible Then
            RxHistForm.Show()
            RxHistFormVisible = True
        End If
        RxHistForm.Display()
    End Sub
    Public Function ClockDigit(ByVal value As Integer) As Char
        If value = &HF Then
            Return "0"
        ElseIf value < &HF Then
            Return " "
        Else
            Return Chr(value)
        End If
    End Function

    Public Sub S0Text(ByVal ptr As Integer, ByVal cnt As Integer, ByRef text As String)
        Dim temp As String

        temp = ""
        For i = 1 To cnt
            temp &= ClockDigit(screen0(ptr + i - 1))
        Next
        text = temp
    End Sub

    Public Sub S1Text(ByVal ptr As Integer, ByVal cnt As Integer, ByRef text As String)
        Dim temp As String
        temp = ""
        For i = 1 To cnt
            temp &= ClockDigit(screen1(ptr + i - 1))
        Next
        text = temp
    End Sub

    Private Sub btnScreen0_Click(sender As Object, e As EventArgs) Handles btnScreen0.Click
        displayScreen0()
    End Sub

    Private Sub btnScreen1_Click(sender As Object, e As EventArgs) Handles btnscreen1.Click
        displayScreen1()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If btnCapture.BackColor = Color.LightGreen Then
            btnCapture.BackColor = Color.LightGray
        Else
            btnCapture.BackColor = Color.LightGreen
            RtxOutput.Text = ""
        End If
    End Sub

End Class
