Public Class SetForm
    Dim temp As String
    Dim lbltemp As String
    Dim type As Integer
    Dim ScreenKind As Integer
    Dim i As Integer

    Public Sub Display()
        lblPage.Text = CStr(screen0(&H2D))
        lblPages.Text = CStr(screen0(&H2F))
        GetButton(0, lblTitle.Text, lbltemp, i)

        'lblInfo.Text = Hex(screen0(&H97))
        lblInfo.Visible = False

        'Button 1
        type = screen0(&H33)
        GetButton(1, temp, lbltemp, ScreenKind)
        btnButton1.Text = temp
        lblButton1.Text = lbltemp
        If temp <> "" Then
            btnButton1.Enabled = True
        Else
            btnButton1.Enabled = False
        End If
        Select Case type
            Case 2
                Select Case ScreenKind
                    Case 1
                        lblButton1.Visible = True
                        pgbButton1.Visible = False
                    Case 2
                        Terminal.S1Text(&H16, 4, temp)
                        lblButton1.Text = temp
                        lblButton1.Visible = True
                        pgbButton1.Value = Math.Min(screen1(&H15) / 60 * 100, pgbButton1.Maximum)
                        pgbButton1.Visible = True
                    Case 3
                        lblButton1.Text = "---- - ----"
                        lblButton1.Visible = True
                        pgbButton1.Visible = False
                    Case Else
                        lblButton1.Visible = False
                        pgbButton1.Visible = False
                End Select
            Case Else
                Select Case ScreenKind
                    Case 4  'Call Sign Screen UR Info
                        Terminal.S1Text(&H15, 3, btnButton1.Text)
                        btnButton1.Text &= " "
                        Terminal.S1Text(&H2A, 9, temp)
                        btnButton1.Text &= temp
                        Terminal.S1Text(&H18, 17, lblButton1.Text)
                        lblButton1.Visible = True
                        pgbButton1.Visible = False
                    Case Else
                        lblButton1.Visible = False
                        pgbButton1.Visible = False
                End Select
        End Select

        'Button 2
        type = screen0(&H4C)
        GetButton(2, temp, lblButton2.Text, ScreenKind)
        btnButton2.Text = temp
        If temp <> "" Then
            btnButton2.Enabled = True
        Else
            btnButton2.Enabled = False
        End If
        Select Case type
            Case 2
                Select Case ScreenKind
                    Case 1
                        lblButton2.Visible = True
                        pgbButton2.Visible = False
                    Case 2
                        Terminal.S1Text(&H64, 4, temp)
                        lblButton2.Text = temp
                        lblButton2.Visible = True
                        pgbButton2.Value = Math.Min(screen1(&H63) / 60 * 100, pgbButton2.Maximum)
                        pgbButton2.Visible = True
                    Case 3
                        lblButton2.Text = "---- - ----"
                        lblButton2.Visible = True
                        pgbButton2.Visible = False
                End Select
            Case Else
                Select Case ScreenKind
                    Case 4  'Call Sign Screen R1 Info
                        Terminal.S1Text(&H63, 3, btnButton2.Text)
                        btnButton2.Text &= " "
                        Terminal.S1Text(&H78, 9, temp)
                        btnButton2.Text &= temp
                        Terminal.S1Text(&H66, 17, lblButton2.Text)
                        lblButton2.Visible = True
                        pgbButton2.Visible = False
                    Case Else
                        lblButton2.Visible = False
                        pgbButton2.Visible = False
                End Select
        End Select

        'Button3 3
        type = screen0(&H65)
        GetButton(3, temp, lblButton3.Text, ScreenKind)
        btnButton3.Text = temp
        If temp <> "" Then
            btnButton3.Enabled = True
        Else
            btnButton3.Enabled = False
        End If
        Select Case type
            Case 2
                Select Case ScreenKind
                    Case 1
                        lblButton3.Visible = True
                        pgbButton3.Visible = False
                    Case 2
                        Terminal.S1Text(&HB2, 4, temp)
                        lblButton3.Text = temp
                        lblButton3.Visible = True
                        pgbButton3.Value = Math.Min(screen1(&HB1) / 60 * 100, pgbButton3.Maximum)
                        pgbButton3.Visible = True
                    Case 3
                        lblButton3.Text = "---- - ----"
                        lblButton3.Visible = True
                        pgbButton3.Visible = False
                    Case 4  'Call Sign Screen
                End Select
            Case Else
                lblButton3.Visible = False
                pgbButton3.Visible = False
        End Select
        'Button 4
        type = screen0(&H7E)
        GetButton(4, temp, lblButton4.Text, ScreenKind)
        btnButton4.Text = temp
        If temp <> "" Then
            btnButton4.Enabled = True
        Else
            btnButton4.Enabled = False
        End If
        Select Case type
            Case 2
                Select Case ScreenKind
                    Case 1
                        lblButton4.Visible = True
                        pgbButton4.Visible = False
                    Case 2
                        Terminal.S1Text(&H100, 4, temp)
                        lblButton4.Text = temp
                        lblButton4.Visible = True
                        pgbButton4.Value = Math.Min(screen1(&HFF) / 60 * 100, pgbButton4.Maximum)
                        pgbButton4.Visible = True
                    Case 3
                        lblButton4.Text = "---- - ----"
                        lblButton4.Visible = True
                        pgbButton4.Visible = False
                    Case 4  'Call Sign Screen
                End Select
            Case Else
                lblButton4.Visible = False
                pgbButton4.Visible = False
        End Select

        btnButton1.BackColor = Color.LightGray
        btnButton1.ForeColor = Color.Black
        lblButton1.BackColor = Color.LightGray
        lblButton1.ForeColor = Color.Black
        pgbButton1.BackColor = Color.LightGray
        pgbButton1.ForeColor = Color.Black

        btnButton2.BackColor = Color.LightGray
        btnButton2.ForeColor = Color.Black
        lblButton2.BackColor = Color.LightGray
        lblButton2.ForeColor = Color.Black
        pgbButton2.BackColor = Color.LightGray
        pgbButton2.ForeColor = Color.Black

        btnButton3.BackColor = Color.LightGray
        btnButton3.ForeColor = Color.Black
        lblButton3.BackColor = Color.LightGray
        lblButton3.ForeColor = Color.Black
        pgbButton3.BackColor = Color.LightGray
        pgbButton3.ForeColor = Color.Black

        btnButton4.BackColor = Color.LightGray
        btnButton4.ForeColor = Color.Black
        lblButton4.BackColor = Color.LightGray
        lblButton4.ForeColor = Color.Black
        pgbButton4.BackColor = Color.LightGray
        pgbButton4.ForeColor = Color.Black

        Select Case screen0(&H97)
            Case 1
                btnButton1.Focus()
                btnButton1.BackColor = Color.Black
                btnButton1.ForeColor = Color.LightGray
                lblButton1.BackColor = Color.Black
                lblButton1.ForeColor = Color.LightGray
                pgbButton1.BackColor = Color.Black
                pgbButton1.ForeColor = Color.LightGray
            Case 2
                btnButton2.Focus()
                btnButton2.BackColor = Color.Black
                btnButton2.ForeColor = Color.LightGray
                lblButton2.BackColor = Color.Black
                lblButton2.ForeColor = Color.LightGray
                pgbButton2.BackColor = Color.Black
                pgbButton2.ForeColor = Color.LightGray
            Case 3
                btnButton3.Focus()
                btnButton3.BackColor = Color.Black
                btnButton3.ForeColor = Color.LightGray
                lblButton3.BackColor = Color.Black
                lblButton3.ForeColor = Color.LightGray
                pgbButton3.BackColor = Color.Black
                pgbButton3.ForeColor = Color.LightGray
            Case 4
                btnButton4.Focus()
                btnButton4.BackColor = Color.Black
                btnButton4.ForeColor = Color.LightGray
                lblButton4.BackColor = Color.Black
                lblButton4.ForeColor = Color.LightGray
                pgbButton4.BackColor = Color.Black
                pgbButton4.ForeColor = Color.LightGray
            Case Else
                btnButton1.Focus()
        End Select
    End Sub

    Public Sub GetButton(ByVal Button As Integer, ByRef Label As String, ByRef lblButton As String, ByRef Kind As Integer)
        Dim Pos As Integer

        Kind = 0
        Label = ""
        lblButton = ""

        Select Case Button
            Case 0
                Pos = &H2A
            Case 1
                Pos = &H34
            Case 2
                Pos = &H4D
            Case 3
                Pos = &H66
            Case 4
                Pos = &H7F
            Case Else
                Stop
        End Select

        If screen0(&HD) = 5 And Button = 0 And screen0(Pos) = 0 Then
            Label = "SET"
            Return
        ElseIf screen0(&HD) = 5 And screen0(Pos - 1) = 0 Then
            Label = ""
            Return
        End If

        Select Case screen0(Pos)
            Case &H0
                Label = "Monitor"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H1
                Label = "Monitor Level"
                Kind = 2    'Percent Screen is used
            Case &H2
                Label = "Beep Level"
                Kind = 2    'Percent Screen is used
            Case &H3
                If lblTitle.Text = "SD CARD" Then
                    Label = "Format"
                Else
                    Label = "Beep Level Limit"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H4
                If lblTitle.Text = "SD CARD" Then
                    Label = "Unmount"
                Else
                    Label = "Beep (Confirmation)"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H5
                If (lblTitle.Text = "FUNCTION") Or (Button = 0) Then
                    Label = "Band Edge Beep"
                    SelectCnt = 4
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON (Default)"
                    SelectInfo(2) = "ON (User)"
                    SelectInfo(3) = "ON (User) & TX Limit"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "Save Setting"
                End If
            Case &H6
                If lblTitle.Text = "SD CARD" Then
                    Label = "Load Setting"
                Else
                    Label = "RF/SQL Control"
                    SelectCnt = 3
                    SelectInfo(0) = "Auto"
                    SelectInfo(1) = "SQL"
                    SelectInfo(2) = "RF+SQL"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H7
                If lblTitle.Text = "SAVE SETTING" Then
                    Label = "Next Entry"
                Else
                    Label = "HF"
                End If
            Case &H8
                If lblTitle.Text = "SAVE SETTING" Then
                    Label = "First SD entry"
                Else
                    Label = "50M"
                End If
            Case &H9
                Label = "Sd Card Entry"    'Load setting from SD Card
            Case &HA
                Label = "144M"
            Case &HB
                Label = "430M"
            Case &HC
                Label = "Time-Out Timer"
                SelectCnt = 6
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "3 min"
                SelectInfo(2) = "5 min"
                SelectInfo(3) = "10 min"
                SelectInfo(4) = "20 min"
                SelectInfo(5) = "30 min"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &HD
                If (lblTitle.Text = "SET") Or (Button = 0) Then
                    Label = "Voice Memo"
                Else
                    Label = "PTT Lock"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &HE
                Label = "QSO Recorder"
            Case &H11
                Label = "<<REC Start>>"
            Case &H13
                If lblTitle.Text = "TUNER" Then
                    Label = "Auto Start"
                Else
                    Label = "Play Files"
                End If
            Case &H14
                Label = "PTT Start"
            Case &H15
                Label = "Recorder Set"
            Case &H16
                If lblTitle.Text = "TUNER" Then
                    Label = "[TUNER] Switch"
                Else
                    Label = "Player Set"
                End If
            Case &H17
                If Button = 0 Or (lblTitle.Text = "FUNCTION") Then
                    Label = "[SPEECH/LOCK] Switch"
                    SelectCnt = 2
                    SelectInfo(0) = "SPEECH/LOCK"
                    SelectInfo(1) = "LOCK/SPEECH"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "DV Auto Reply"
                End If
            Case &H18
                If (Button = 0) Or (lblTitle.Text = "SET") Then
                    Label = "DV Set"
                    SelectCnt = 2
                    SelectInfo(0) = "ALL"
                    SelectInfo(1) = "Latest Only"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "Lock Function"
                    SelectCnt = 2
                    SelectInfo(0) = "MAIN DIAL"
                    SelectInfo(1) = "PANEL"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H19
                If lblTitle.Text = "SET" Then
                    Label = "SPEECH"
                Else
                    Label = "Memopad Numbers"
                    SelectCnt = 2
                    SelectInfo(0) = "5"
                    SelectInfo(1) = "10"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H1A
                If lblTitle.Text = "SET" Then
                    Label = "QSO/RX Log"
                Else
                    Label = "MAIN DIAL Auto TS"
                    SelectCnt = 3
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "LOW"
                    SelectInfo(2) = "HIGH"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H1B
                If lblTitle.Text = "FUNCTION" Then
                    Label = "MIC Up/Down Speed"
                    SelectCnt = 2
                    SelectInfo(0) = "Slow"
                    SelectInfo(1) = "Fast"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "CSV Format"
                End If
            Case &H1C
                If Button = 0 Or (screen0(&H2D) = 3) Then
                    Label = "Function"
                Else
                    Label = "[NOTCH] Switch (SSB)"
                    SelectCnt = 3
                    SelectInfo(0) = "Auto"
                    SelectInfo(1) = "Manual"
                    SelectInfo(2) = "Auto/Manual"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H1D
                If lblTitle.Text = "FUNCTION" And (screen0(&H2D) = 5) Then
                    Label = "[NOTCH] Switch (AM)"
                    SelectCnt = 3
                    SelectInfo(0) = "Auto"
                    SelectInfo(1) = "Manual"
                    SelectInfo(2) = "Auto/Manual"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "TX Delay"
                End If
            Case &H1E
                If (screen0(&HD) = 7) Or (lblTitle.Text = "FUNCTION" And (screen0(&H2D) = 5)) Then
                    Label = "SSB/CW Sync Tuning"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "SPLIT/DUP"
                    SelectCnt = 6
                    SelectInfo(0) = "Quick SPLIT"
                    SelectInfo(1) = "SPLIT Offset"
                    SelectInfo(2) = "SPLIT LOCK"
                    SelectInfo(3) = "DUP Offset"
                    SelectInfo(4) = "One Touch Repeater"
                    SelectInfo(5) = "Auto Repeater"
                    Kind = 1    'Select Screen is used
                End If
            Case &H1F
                If ((lblTitle.Text = "FUNCTION" And (screen0(&H2D) = 6))) Or (screen0(&HD) = 7) Then
                    Label = "CW Normal Side"
                    SelectCnt = 2
                    SelectInfo(0) = "LSB"
                    SelectInfo(1) = "USB"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "Tuner"
                End If
            Case &H20
                If (lblTitle.Text = "FUNCTION" And (screen0(&H2D) = 6)) Or (screen0(&HD) = 7) Then
                    Label = "VOICE 1st Menu"
                    SelectCnt = 2
                    SelectInfo(0) = "VOICE-Root"
                    SelectInfo(1) = "VOICE-TX"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RC MIC"
                    SelectCnt = 3
                    SelectInfo(0) = "[F-1]"
                    SelectInfo(1) = "[F-2]"
                    SelectInfo(2) = "Mode Select"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H21
                If lblTitle.Text = "FUNCTION" Then
                    Label = "KEYER 1st Menu"
                    SelectCnt = 2
                    SelectInfo(0) = "KEYER-Root"
                    SelectInfo(1) = "KEYER-SEND"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "Tone Control"
                End If
            Case &H22
                If lblTitle.Text = "FUNCTION" Then
                    Label = "Speaker Out"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RX"
                End If
            Case &H23
                If lblTitle.Text = "FUNCTION" Then
                    Label = "MIC AF Out"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "SSB"
                    SelectCnt = 3
                    SelectInfo(0) = "RX HPF/LPF"
                    SelectInfo(1) = "RX Bass"
                    SelectInfo(2) = "RX Treble"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 3    'Tone Control Screen is used
                End If
            Case &H24
                If screen0(&HD) = 5 Then
                    Label = "AM"
                Else
                    Label = "[F-1]"
                End If
            Case &H25
                If screen0(&HD) = 5 Then
                    Label = "FM"
                Else
                    Label = "[F-2]"
                End If
            Case &H26
                If screen0(&HD) = 5 Then
                    Label = "DV"
                Else
                    Label = "Mode Select"
                End If
            Case &H27   'RX
                Label = "WFM"
            Case &H28   'RX
                Label = "CW"
            Case &H29
                If screen0(&HD) = 5 Then
                    Label = "RTTY"
                Else
                    Label = "R1:"
                    Kind = 4
                End If
            Case &H2A
                Label = "TX"
            Case &H2B
                Label = "SSB" 'TX
            Case &H2C
                Label = "AM"  'TX
            Case &H2D
                If lblTitle.Text = "FUNCTION" Then
                    Label = "Power OFF (With No Controller)"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "FM"
                End If
            Case &H2E
                If lblTitle.Text = "TX" Then
                    Label = "DV"
                Else
                    Label = "REF Adjust"
                    Kind = 2
                End If
            Case &H2F
                If lblTitle.Text = "SET" Then
                    Label = "Connectors"
                Else
                    Label = "RX HPF/LPF"    'SSB
                End If
            Case &H30
                Label = "External Keypad"
            Case &H31
                If (lblTitle.Text = "CONNECTORS") Or (Button = 0) Then
                    Label = "CI-V"
                Else
                    Label = "RX Bass"   'SSB
                End If
            Case &H32
                If (lblTitle.Text = "CONNECTORS") Or (Button = 0) Then
                    Label = "USB2/DATA1 Function"
                Else
                    Label = "RX Treble" 'SSB
                End If
            Case &H33
                If (lblTitle.Text = "SET") Or (Button = 0) Then
                    Label = "GPS"
                    SelectCnt = 3
                    SelectInfo(0) = "GPS Alarm"
                    SelectInfo(1) = "GPS TX Mode"
                    SelectInfo(2) = "GPS Auto TX"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RX HPF/LPF"    'AM
                End If
            Case &H34
                Label = "GPS Set"
            Case &H35
                If (lblTitle.Text = "GPS") Or (Button = 0) Then
                    Label = "GPS Alarm"
                Else
                    Label = "RX Bass"   'AM
                End If
            Case &H36
                If lblTitle.Text = "GPS MEMORY" Then
                    Label = "(No Group)"
                ElseIf lblTitle.Text = "GPS ALARM" Then
                    Label = "Alarm Select"
                    SelectCnt = 4
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "RX"
                    SelectInfo(2) = "Group"
                    SelectInfo(3) = "Memory"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RX Treble" 'AM
                End If
            Case &H37
                If lblTitle.Text = "FUNCTION" Then
                    Label = "A:"
                Else
                    Label = "RX HPF/LPF"    'FM
                End If
            Case &H39
                Label = "RX Bass"   'FM
            Case &H3A
                If lblTitle.Text = "SET" Then
                    Label = "Display"
                ElseIf lblTitle.Text = "ALARM SELECT" Then
                    Label = "OFF"
                Else
                    Label = "RX Treble" 'FM
                End If
            Case &H3B
                If (lblTitle.Text = "RX") Or (lblTitle.Text = "DV") Then
                    Label = "RX HPF/LPF"    'DV
                ElseIf lblTitle.Text = "GPS ALARM" Then
                    Label = "Alarm Area (Group)"
                Else
                    Label = "Time Set"
                End If
            Case &H3C
                Label = "Date/Time"
            Case &H3D
                If lblTitle.Text = "CLONE" Then
                    Label = "Clone Mode"
                ElseIf lblTitle.Text = "SET" Then
                    Label = "Others"
                    SelectCnt = 1
                    SelectInfo(0) = "Version"
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RX Bass"    'DV
                End If
            Case &H3E
                If lblTitle.Text = "CLONE" Then
                    Label = "Clone Master Mode"
                    SelectCnt = 2
                    SelectInfo(0) = "Clone Mode"
                    SelectInfo(1) = "Clone Master Mode"
                    Kind = 1    'Select Screen is used
                ElseIf lblTitle.Text = "OTHERS" Then
                    Label = "Information"
                Else
                    Label = "RX Treble"   'DV
                End If
            Case &H3F
                If lblTitle.Text = "INFORMATION" Then
                    Label = "Version"
                ElseIf lblTitle.Text = "OTHERS" Then
                    Label = "Touch Screen Calibration"
                Else
                    Label = "RX Bass" 'WFM
                End If
            Case &H40
                If lblTitle.Text = "RESET" Then
                    Label = "Partial Reset"
                ElseIf lblTitle.Text = "OTHERS" Then
                    Label = "Clone"
                Else
                    Label = "RX Treble" 'WFM
                End If
            Case &H41
                If lblTitle.Text = "RESET" Then
                    Label = "All Reset"
                ElseIf lblTitle.Text = "OTHERS" Then
                    Label = "Reset"
                Else
                    Label = "RX HPF/LPF"
                End If
            Case &H43
                Label = "RX HPF/LPF"
            Case &H45
                Label = "TX Bass"
            Case &H46
                Label = "TX Treble"
            Case &H47
                Label = "TX Bass"
            Case &H48
                Label = "TX Treble"
            Case &H49
                Label = "TX Bass"
            Case &H4A
                Label = "TX Treble"
            Case &H4B
                Label = "TX Bass"
            Case &H4C
                If lblTitle.Text = "SET" Then
                    Label = "SD Card"
                Else
                    Label = "TX Treble"
                End If
            Case &H4D
                If lblTitle.Text = "SSB" Then
                    Label = "TBW (WIDE)"
                Else
                    Label = "Save Setting"    'Save Settings to SD card
                End If
            Case &H4E
                Label = "Load Setting"    'Load Settings from SD card
            Case &H4F
                Label = "TBW (MID)"
            Case &H51
                If lblTitle.Text = "SSB" Then
                    Label = "TBW (NAR)"
                Else
                    Label = "SD Card Info"
                End If
            Case &H52
                Label = "GPS Position"
            Case &H53
                Label = "VSEND Select"
                SelectCnt = 3
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "UHF"
                SelectInfo(2) = "VHF/UHF"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H54
                If lblTitle.Text = "EXTERNAL KEYPAD" Then
                    Label = "VOICE"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "GPS Information"
                End If
            Case &H55
                If lblTitle.Text = "EXTERNAL KEYPAD" Then
                    Label = "KEYER"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "ON"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "GPS Memory"
                End If
            Case &H56
                Label = "RTTY"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H57
                Label = "USB Audio SQL"
            Case &H58
                Label = "ACC/USB Output Select"
            Case &H59
                Label = "ACC/USB AF Level"
            Case &H5A
                Label = "ACC/USB IF Level"
            Case &H5B
                Label = "ACC Mod Level"
            Case &H5C
                Label = "DATA Mod Level"
            Case &H5D
                Label = "USB Mod Level"
            Case &H5E
                If lblTitle.Text = "CONNECTORS" Then
                    Label = "DATA OFF Mod"
                Else
                    Label = "Call Sign"
                End If
            Case &H5F
                If lblTitle.Text = "CALL SIGN" Then
                    Label = "UR:CQCQCQ"
                    Kind = 4    'Call Sign Screen
                Else
                    Label = "DATA MOD"
                    SelectCnt = 4
                    SelectInfo(0) = "MIC"
                    SelectInfo(1) = "ACC"
                    SelectInfo(2) = "MIC,ACC"
                    SelectInfo(3) = "USB"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                End If
            Case &H60
                If lblTitle.Text = "CI-V" Then
                    Label = "CI-V Baud Rate"
                    SelectCnt = 6
                    SelectInfo(0) = "300"
                    SelectInfo(1) = "1200"
                    SelectInfo(2) = "4800"
                    SelectInfo(3) = "9600"
                    SelectInfo(4) = "19200"
                    SelectInfo(5) = "Auto"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "R2: NOT USED*"
                    Kind = 4
                End If
            Case &H61
                If lblTitle.Text = "CI-V" Then
                    Label = "CI-V Address"
                    Kind = 2
                Else
                    Label = "MY:"
                    Kind = 4
                End If
            Case &H62
                Label = "CI-V Transceive"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H63
                Label = "CI-V Output (for ANT)"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H64
                Label = "USB2 Function"
                SelectCnt = 3
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "RTTY Decode"
                SelectInfo(2) = "DV Data"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H65
                Label = "DATA1 Function"
                SelectCnt = 4
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "RTTY Decode"
                SelectInfo(2) = "DV Data"
                SelectInfo(3) = "GPS"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H66
                If lblTitle.Text = "USB2/DATA1 FUNCTION" Then
                    Label = "GPS Out"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "DATA1-->USB2"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "RX History"
                End If
            Case &H67
                Label = "DV Data/GPS Out Baud"
                SelectCnt = 2
                SelectInfo(0) = "4800"
                SelectInfo(1) = "9600"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H68
                Label = "RTTY Decode Baud"
                SelectCnt = 5
                SelectInfo(0) = "300"
                SelectInfo(1) = "1200"
                SelectInfo(2) = "4800"
                SelectInfo(3) = "9600"
                SelectInfo(4) = "19200"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H69
                Label = "9600 bps Mode"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H6A
                Label = "LCD Contrast"
                Kind = 2    'Percent Screen is used
            Case &H6B
                Label = "LCD Backlight"
                Kind = 2    'Percent Screen is used
            Case &H6C
                Label = "Key Backlight"
                Kind = 2    'Percent Screen is used
            Case &H6D
                Label = "Meter Peak Hold"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H6E
                Label = "BW Popup (PBT)"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H6F
                Label = "BW Popup (FIL)"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H70
                Label = "RX Call Sign Display"
                SelectCnt = 3
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "Auto"
                SelectInfo(2) = "Auto (RX Hold)"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H71
                Label = "RX Message Display"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "Auto"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H72
                Label = "Reply Position Display"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H73
                Label = "TX Call Sign Display"
                SelectCnt = 3
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "Your Call Sign"
                SelectInfo(2) = "My Call Sign"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H74
                Label = "Scroll Speed"
                SelectCnt = 2
                SelectInfo(0) = "Slow"
                SelectInfo(1) = "Fast"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H75
                Label = "VOICE TX Name Display"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H76
                Label = "KEYER Memory Display"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H77
                Label = "Opening Message"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H78
                Label = "Power ON Check"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H7A
                Label = "System Language"
                SelectCnt = 2
                SelectInfo(0) = "English"
                SelectInfo(1) = "Japanese"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H7B
                If lblTitle.Text = "DATE/TIME" Then
                    Label = "DATE"
                Else
                    Label = "My Station"
                End If
            Case &H7C
                Label = "MY Call Sign"
            Case &H7D
                Label = "TX Message"
            Case &H7E
                Label = "TIME"
            Case &H80
                If lblTitle.Text = "TIME SET" Then
                    Label = "GPS Time Correct"
                    SelectCnt = 2
                    SelectInfo(0) = "OFF"
                    SelectInfo(1) = "Auto"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "DV Memory"
                End If
            Case &H81
                If lblTitle.Text = "TIME SET" Then
                    Label = "UTC Offset"
                Else
                    Label = "Repeater List"
                End If
            Case &H82
                If lblTitle.Text = "TIME SET" Then
                    Label = "Clock Display"
                    SelectCnt = 2
                    SelectInfo(0) = "Local"
                    SelectInfo(1) = "UTC"
                    lblButton = SelectInfo(screen0(Pos + 2))
                    Kind = 1    'Select Screen is used
                Else
                    Label = "Your Call Sign"
                End If
            Case &H83
                Label = "Auto Power OFF"
                SelectCnt = 5
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "30 min"
                SelectInfo(2) = "60 min"
                SelectInfo(3) = "90 min"
                SelectInfo(4) = "120 min"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H84
                Label = "Save Form"
                SelectCnt = 2
                SelectInfo(0) = "Now Ver"
                SelectInfo(1) = "Old Ver (1.00 - 1.04)"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H85
                If lblTitle.Text = "GPS SET" Then
                    Label = "Manual Position"
                Else
                    Label = "Auto Reply"
                End If
            Case &H86
                Label = "DV Data TX"
            Case &H87
                Label = "Digital Monitor"
            Case &H88
                Label = "Digital Repeater Set"
            Case &H89
                Label = "RX Call Sign Write"
            Case &H8A
                Label = "RX Repeater Write"
            Case &H8B
                Label = "DV Auto Detect"
            Case &H8C
                Label = "RX Record (RPT)"
                SelectCnt = 2
                SelectInfo(0) = "ALL"
                SelectInfo(1) = "Latest Only"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H8D
                Label = "BK"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H8E
                Label = "EMR"
                SelectCnt = 2
                SelectInfo(0) = "OFF"
                SelectInfo(1) = "ON"
                lblButton = SelectInfo(screen0(Pos + 2))
                Kind = 1    'Select Screen is used
            Case &H8F
                Label = "EMR AF Level"
                Kind = 2    'Percent Screen is used
            Case &H90
                Label = "Standby Beep"
            Case &H91
                Label = "GPS TX Mode"
            Case &H92
                Label = "GPS Auto TX"
            Case &H93
                Label = "GPS Select"
            Case &H94
                Label = "GPS Receiver Baud Rate"
            Case &H95
                Label = "GPS Indicator"
            Case &H99
                Label = "Alarm Area (Group)"
            Case &H9B
                Label = "Alarm Area (RX/Memory)"
            Case &HB6
                Label = "RX Call Sign SPEECH"
            Case &HB7
                Label = "RX>CS SPEECH"
            Case &HB8
                Label = "S-Level SPEECH"
            Case &HB9
                Label = "MODE SPEECH"
            Case &HBA
                Label = "SPEECH Language"
            Case &HBB
                Label = "Alphabet"
            Case &HBC
                Label = "SPEECH Speed"
            Case &HBD
                Label = "SPEECH Level"
            Case &HBE
                Label = "QSO Log"
            Case &HBF
                Label = "RX History Log"
            Case &HC0
                Label = "Separator/Decimal"
            Case &HC1
                Label = "Date"
            Case Else
                Label = "Unknown: " & Hex(screen0(Pos))
        End Select
        If Button = 0 Then
            Label = UCase(Label)
        End If
    End Sub

    Private Sub ButtonSet(ByRef Title As String, ByRef Label1 As String, ByVal Type1 As Integer, ByRef Label2 As String, ByVal Type2 As Integer,
                          ByRef Label3 As String, ByVal Type3 As Integer, ByRef Label4 As String, ByVal Type4 As Integer)

    End Sub

    Private Sub btnButton1_MouseDown(sender As Object, e As EventArgs) Handles btnButton1.MouseDown
        ScrnTitle = btnButton1.Text
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H1)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton1_MouseUp(sender As Object, e As EventArgs) Handles btnButton1.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton2_MouseDown(sender As Object, e As EventArgs) Handles btnButton2.MouseDown
        ScrnTitle = btnButton2.Text
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H2)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton2_MouseUp(sender As Object, e As EventArgs) Handles btnButton2.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton3_MouseDown(sender As Object, e As EventArgs) Handles btnButton3.MouseDown
        ScrnTitle = btnButton3.Text
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H3)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton3_MouseUp(sender As Object, e As EventArgs) Handles btnButton3.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton4_MouseDown(sender As Object, e As EventArgs) Handles btnButton4.MouseDown
        ScrnTitle = btnButton4.Text
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H4)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton4_MouseUp(sender As Object, e As EventArgs) Handles btnButton4.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnUp_MouseDown(sender As Object, e As EventArgs) Handles btnUp.MouseDown
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H5)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnUp_MouseUp(sender As Object, e As EventArgs) Handles btnUp.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnDown_MouseDown(sender As Object, e As EventArgs) Handles btnDown.MouseDown
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H6)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnDown_MouseUp(sender As Object, e As EventArgs) Handles btnDown.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnBack_MouseDown(sender As Object, e As EventArgs) Handles btnBack.MouseDown
        Screen.Send(&H14)
        Screen.Send(&H5)
        Screen.Send(&H7)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnBack_MouseUp(sender As Object, e As EventArgs) Handles btnBack.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

End Class