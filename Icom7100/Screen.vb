Public Class Screen
    Dim Message(10) As Byte
    Dim MsgPtr As Integer = 1
    Dim Bank As Byte = 0
    Dim Channel As Byte = 0
    Dim Tune As Integer = 0

    Private Sub Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrMessage.Interval = 100     'Set the timer to 100ms
        tmrMessage.Enabled = True     'Start the timer
    End Sub

    Private Sub tmrMessage_Tick(sender As Object, e As EventArgs) Handles tmrMessage.Tick
        Dim Msg() As Byte = {&HFE, 0, 0, &HFD}

        If Terminal.SerialPort.IsOpen Then
            If Terminal.SerialPort.CtsHolding = True Then
                btnOnOff.BackColor = Color.LightGray
            Else
                btnOnOff.BackColor = Color.LightGreen
            End If
        End If
        'If Terminal.SerialPort.IsOpen And Not Busy Then
        ' Terminal.SerialPort.Write(Msg, 0, 4)
        ' End If
    End Sub

    Private Sub btnPTT_MouseDown(sender As Object, e As EventArgs) Handles btnPTT.MouseDown
        btnPTT.BackColor = Color.LightGreen
        Send(&H11)
        Send(&H6)
        SendMessage()
    End Sub
    Private Sub btnPTT_MouseUp(sender As Object, e As EventArgs) Handles btnPTT.MouseUp
        btnPTT.BackColor = Color.LightGray
        Send(&H11)
        Send(&H4)
        SendMessage()
    End Sub

    Private Sub btnMenu_MouseDown(sender As Object, e As EventArgs) Handles btnMenu.MouseDown
        Send(&HF)
        Send(&H8)
        SendMessage()
    End Sub
    Private Sub btnMenu_MouseUp(sender As Object, e As EventArgs) Handles btnMenu.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnNB_MouseDown(sender As Object, e As EventArgs) Handles btnNB.MouseDown
        Send(&HF)
        Send(&H4)
        SendMessage()
    End Sub
    Private Sub btnNB_MouseUp(sender As Object, e As EventArgs) Handles btnNB.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnNR_MouseDown(sender As Object, e As EventArgs) Handles btnNR.MouseDown
        Send(&H10)
        Send(&H80)
        SendMessage()
    End Sub
    Private Sub btnNR_MouseUp(sender As Object, e As EventArgs) Handles btnNR.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnNotch_MouseDown(sender As Object, e As EventArgs) Handles btnNotch.MouseDown
        Send(&H10)
        Send(&H40)
        SendMessage()
    End Sub
    Private Sub btnNotch_MouseUp(sender As Object, e As EventArgs) Handles btnNotch.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnSet_MouseDown(sender As Object, e As EventArgs) Handles btnSet.MouseDown
        Send(&H10)
        Send(&H8)
        SendMessage()
    End Sub
    Private Sub btnSet_MouseUp(sender As Object, e As EventArgs) Handles btnSet.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnPower_MouseDown(sender As Object, e As EventArgs) Handles btnPower.MouseDown
        Send(&HF)
        Send(&H10)
        SendMessage()
    End Sub
    Private Sub btnPower_MouseUp(sender As Object, e As EventArgs) Handles btnPower.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnSpeed_MouseDown(sender As Object, e As EventArgs) Handles btnSpeed.MouseDown
        Send(&HF)
        Send(&H2)
        SendMessage()
    End Sub
    Private Sub btnSpeed_MouseUp(sender As Object, e As EventArgs) Handles btnSpeed.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnPamp_MouseDown(sender As Object, e As EventArgs) Handles btnPamp.MouseDown
        Send(&HF)
        Send(&H1)
        SendMessage()
    End Sub
    Private Sub btnPamp_MouseUp(sender As Object, e As EventArgs) Handles btnPamp.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnDR_MouseDown(sender As Object, e As EventArgs) Handles btnDR.MouseDown
        Send(&H10)
        Send(&H20)
        SendMessage()
    End Sub
    Private Sub btnDR_MouseUp(sender As Object, e As EventArgs) Handles btnDR.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnQuick_MouseDown(sender As Object, e As EventArgs) Handles btnQuick.MouseDown
        Send(&H10)
        Send(&H4)
        SendMessage()
    End Sub
    Private Sub btnQuick_MouseUp(sender As Object, e As EventArgs) Handles btnQuick.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnRIT_MouseDown(sender As Object, e As EventArgs) Handles btnRIT.MouseDown
        Send(&HF)
        Send(&H40)
        SendMessage()
    End Sub
    Private Sub btnRIT_MouseUp(sender As Object, e As EventArgs) Handles btnRIT.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnTuner_MouseDown(sender As Object, e As EventArgs) Handles btnTuner.MouseDown
        Send(&HF)
        Send(&H20)
        SendMessage()
    End Sub
    Private Sub btnTuner_MouseUp(sender As Object, e As EventArgs) Handles btnTuner.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnAutoTune_MouseDown(sender As Object, e As EventArgs) Handles btnAutoTune.MouseDown
        Send(&H10)
        Send(&H2)
        SendMessage()
    End Sub
    Private Sub btnAutoTune_MouseUp(sender As Object, e As EventArgs) Handles btnAutoTune.MouseUp
        Send(&H10)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnSpeech_MouseDown(sender As Object, e As EventArgs) Handles btnSpeech.MouseDown
        Send(&HE)
        Send(&H20)
        SendMessage()
    End Sub
    Private Sub btnSpeech_MouseUp(sender As Object, e As EventArgs) Handles btnSpeech.MouseUp
        Send(&HE)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnXFC_MouseDown(sender As Object, e As EventArgs) Handles btnXFC.MouseDown
        Send(&HE)
        Send(&H40)
        SendMessage()
    End Sub
    Private Sub btnXFC_MouseUp(sender As Object, e As EventArgs) Handles btnXFC.MouseUp
        Send(&HE)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnMpad_MouseDown(sender As Object, e As EventArgs) Handles btnMpad.MouseDown
        Send(&HE)
        Send(&H80)
        SendMessage()
    End Sub
    Private Sub btnMpad_MouseUp(sender As Object, e As EventArgs) Handles btnMpad.MouseUp
        Send(&HE)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnCLR_MouseDown(sender As Object, e As EventArgs) Handles btnCLR.MouseDown
        Send(&HF)
        Send(&H80)
        SendMessage()
    End Sub
    Private Sub btnCLR_MouseUp(sender As Object, e As EventArgs) Handles btnCLR.MouseUp
        Send(&HF)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnMode_MouseDown(sender As Object, e As EventArgs) Handles btnMode.MouseDown
        Send(&H14)
        Send(&H1)
        Send(&H1)
        Send(&H0)
        SendMessage()
    End Sub
    Private Sub btnMode_MouseUp(sender As Object, e As EventArgs) Handles btnMode.MouseUp
        Send(&H14)
        Send(&H0)
        Send(&H0)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnFilter_MouseDown(sender As Object, e As EventArgs) Handles btnFilter.MouseDown
        Send(&H14)
        Send(&H1)
        Send(&H2)
        Send(&H0)
        SendMessage()
    End Sub
    Private Sub btnFilter_MouseUp(sender As Object, e As EventArgs) Handles btnFilter.MouseUp
        Send(&H14)
        Send(&H0)
        Send(&H0)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnMhz_MouseDown(sender As Object, e As EventArgs) Handles btnMhz.MouseDown
        Send(&H14)
        Send(&H1)
        Send(&H3)
        Send(&H0)
        SendMessage()
    End Sub
    Private Sub btnMhz_MouseUp(sender As Object, e As EventArgs) Handles btnMhz.MouseUp
        Send(&H14)
        Send(&H0)
        Send(&H0)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnKhz_MouseDown(sender As Object, e As EventArgs) Handles btnKhz.MouseDown
        Send(&H14)
        Send(&H1)
        Send(&H4)
        Send(&H0)
        SendMessage()
    End Sub
    Private Sub btnKhz_MouseUp(sender As Object, e As EventArgs) Handles btnKhz.MouseUp
        Send(&H14)
        Send(&H0)
        Send(&H0)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnHz_MouseDown(sender As Object, e As EventArgs) Handles btnHz.MouseDown
        Send(&H14)
        Send(&H1)
        Send(&H5)
        Send(&H0)
        SendMessage()
    End Sub
    Private Sub btnHz_MouseUp(sender As Object, e As EventArgs) Handles btnHz.MouseUp
        Send(&H14)
        Send(&H0)
        Send(&H0)
        Send(&H0)
        SendMessage()
    End Sub

    Private Sub btnButton1_MouseDown(sender As Object, e As EventArgs) Handles btnButton1.MouseDown
        If lblMenuType.Text = "M-2" Then
            If lblDUP.Text = "" Then
                Button(&H0, &H33)
            Else
                Button(&H3, &H33)
            End If
        Else
            Button(&H3, &H33)
        End If
    End Sub
    Private Sub btnButton1_MouseUp(sender As Object, e As EventArgs) Handles btnButton1.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnButton2_MouseDown(sender As Object, e As EventArgs) Handles btnButton2.MouseDown
        Button(&H3, &H34)
    End Sub
    Private Sub btnButton2_MouseUp(sender As Object, e As EventArgs) Handles btnButton2.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnButton3_MouseDown(sender As Object, e As EventArgs) Handles btnButton3.MouseDown
        If lblMenuType.Text = "M-1" Then
            If btnVFO.Text <> "VFOB" Then
                Button(&H3, &H35)
            Else
                Button(&H0, &H35)
            End If
        Else
            Button(&H3, &H35)
        End If
    End Sub
    Private Sub btnButton3_MouseUp(sender As Object, e As EventArgs) Handles btnButton3.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnButton4_MouseDown(sender As Object, e As EventArgs) Handles btnButton4.MouseDown
        If lblMenuType.Text = "M-1" Then
            If btnVFO.Text <> "VFOB" Then
                Button(&H3, &H36)
            Else
                Button(&H0, &H36)
            End If
        Else
            Button(&H3, &H36)
        End If
    End Sub
    Private Sub btnButton4_MouseUp(sender As Object, e As EventArgs) Handles btnButton4.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnButton5_MouseDown(sender As Object, e As EventArgs) Handles btnButton5.MouseDown
        Button(&H3, &H37)
    End Sub
    Private Sub btnButton5_MouseUp(sender As Object, e As EventArgs) Handles btnButton5.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnVFO_MouseDown(sender As Object, e As EventArgs) Handles btnVFO.MouseDown
        Button(&H1, &H8)
    End Sub
    Private Sub btnVFO_MouseUp(sender As Object, e As EventArgs) Handles btnVFO.MouseUp
        Button(&H0, &H0)
    End Sub

    Private Sub btnBankUp_Click(sender As Object, e As EventArgs) Handles btnBankUp.Click
        Send(&H1B)
        Bank = Up(Bank)
        Send(Bank)
        SendMessage()
    End Sub

    Private Sub btnBankDown_Click(sender As Object, e As EventArgs) Handles btnBankDown.Click
        Send(&H1B)
        Bank = Down(Bank)
        Send(Bank)
        SendMessage()
    End Sub

    Private Sub btnChanUp_Click(sender As Object, e As EventArgs) Handles btnChanUp.Click
        Send(&H1A)
        Channel = Up(Channel)
        Send(Channel)
        SendMessage()
    End Sub
    Private Sub btnChanDown_Click(sender As Object, e As EventArgs) Handles btnChanDown.Click
        Send(&H1A)
        Channel = Down(Channel)
        Send(Channel)
        SendMessage()
    End Sub

    Private Sub btnTuneUp_Click(sender As Object, e As EventArgs) Handles btnTuneUp.Click
        Send(&H17)
        If Tune = 65535 Then
            Tune = 0
        Else
            Tune += 1
        End If
        Send(CByte((Tune And &HFF00) >> 8))
        Send(CByte(Tune And &HFF))
        SendMessage()
    End Sub
    Private Sub btnTuneDown_Click(sender As Object, e As EventArgs) Handles btnTuneDown.Click
        Send(&H17)
        If Tune = 0 Then
            Tune = 65535
        Else
            Tune -= 1
        End If
        Send(CByte((Tune And &HFF00) >> 8))
        Send(CByte(Tune And &HFF))
        SendMessage()
    End Sub

    Public Sub Send(ByVal Value As Byte)
        If Value >= &HFD Then
            Message(MsgPtr) = &HFF
            Message(MsgPtr + 1) = &HF And Value
            MsgPtr += 2
        Else
            Message(MsgPtr) = Value
            MsgPtr += 1
        End If
    End Sub

    Public Sub SendMessage()
        Message(0) = &HFE
        Message(MsgPtr) = &HFD
        MsgPtr += 1
        If Terminal.SerialPort.IsOpen Then
            Terminal.SerialPort.Write(Message, 0, MsgPtr)
        End If
        MsgPtr = 1
    End Sub

    Private Sub Button(V1 As Byte, V2 As Byte)
        Send(&H14)
        Send(V1)
        Send(V2)
        Send(&H0)
        SendMessage()
    End Sub

    Private Function Down(ByVal Value As Byte) As Byte
        If Value = 0 Then
            Return 255
        Else
            Value -= 1
            Return Value
        End If
    End Function

    Private Function Up(ByVal Value As Byte) As Byte
        If Value = 255 Then
            Return 0
        Else
            Value += 1
            Return Value
        End If
    End Function

    Private Sub tkbVolume_Scroll(sender As Object, e As EventArgs) Handles tkbVolume.Scroll
        Send(&H1C)
        Send(CByte(tkbVolume.Value))
        SendMessage()
    End Sub

    Private Sub tkbSquelch_Scroll(sender As Object, e As EventArgs) Handles tkbSquelch.Scroll
        Send(&H1D)
        Send(CByte(tkbSquelch.Value))
        SendMessage()
    End Sub

    Private Sub btnOnOff_MouseDown(sender As Object, e As EventArgs) Handles btnOnOff.MouseDown
        Terminal.SerialPort.DtrEnable = True
    End Sub

    Private Sub btnOnOff_MouseUp(sender As Object, e As EventArgs) Handles btnOnOff.MouseUp
        Terminal.SerialPort.DtrEnable = False
    End Sub
End Class