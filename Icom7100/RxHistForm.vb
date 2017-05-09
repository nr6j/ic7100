Public Class RxHistForm
    Dim temp As String

    Public Sub Display()
        lblClock.Text = Screen.lblClock.Text
        Terminal.S0Text(&H34, 5, lblRX.Text)
        Terminal.S0Text(&H4C, 14, lblCallSign.Text)
        Terminal.S0Text(&H6C, 14, temp)
        lblTO.Text = "--" & temp
        Terminal.S0Text(&HA3, 20, lblFROM.Text)
        Terminal.S0Text(&H8C, 8, lblRPT.Text)
        Terminal.S0Text(&HB7, 20, lblDate.Text)
    End Sub
End Class