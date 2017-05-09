Public Class PercentForm
    Public Sub Display()
        Dim i As Integer
        Dim temp As String

        lblTitle.Text = ScrnTitle
        pgbPercent.Value = screen0(&H2C)
        temp = ""
        For i = 0 To 3
            temp &= Terminal.ClockDigit(screen0(&H2D + i))
        Next
        lblPercent.Text = temp
    End Sub

    Private Sub btnUp_MouseDown(sender As Object, e As EventArgs) Handles btnUp.MouseDown
        Screen.Send(&H14)
        Screen.Send(&HD)
        Screen.Send(&H1)
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
        Screen.Send(&HD)
        Screen.Send(&H2)
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
        Screen.Send(&HD)
        Screen.Send(&H4)
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

    Private Sub pgbPercent_MouseDown(sender As Object, e As EventArgs) Handles pgbPercent.MouseDown
        Screen.Send(&H14)
        Screen.Send(&HD)
        Screen.Send(&H4)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub pgbPercent_MouseUp(sender As Object, e As EventArgs) Handles pgbPercent.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

End Class