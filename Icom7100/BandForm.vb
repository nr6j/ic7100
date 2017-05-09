Public Class BandForm
    Private Sub BandForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnButton1_MouseDown(sender As Object, e As EventArgs) Handles btnButton1.MouseDown
        ScrnTitle = btnButton1.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
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
        Screen.Send(&H4)
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
        Screen.Send(&H4)
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
        Screen.Send(&H4)
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

    Private Sub btnButton5_MouseDown(sender As Object, e As EventArgs) Handles btnButton5.MouseDown
        ScrnTitle = btnButton5.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&H5)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton5_MouseUp(sender As Object, e As EventArgs) Handles btnButton5.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton6_MouseDown(sender As Object, e As EventArgs) Handles btnButton6.MouseDown
        ScrnTitle = btnButton6.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&H6)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton6_MouseUp(sender As Object, e As EventArgs) Handles btnButton6.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton7_MouseDown(sender As Object, e As EventArgs) Handles btnButton7.MouseDown
        ScrnTitle = btnButton7.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&H7)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton7_MouseUp(sender As Object, e As EventArgs) Handles btnButton7.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton8_MouseDown(sender As Object, e As EventArgs) Handles btnButton8.MouseDown
        ScrnTitle = btnButton8.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&H8)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton8_MouseUp(sender As Object, e As EventArgs) Handles btnButton8.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton9_MouseDown(sender As Object, e As EventArgs) Handles btnButton9.MouseDown
        ScrnTitle = btnButton9.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&H9)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton9_MouseUp(sender As Object, e As EventArgs) Handles btnButton9.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton10_MouseDown(sender As Object, e As EventArgs) Handles btnButton10.MouseDown
        ScrnTitle = btnButton10.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&HA)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton10_MouseUp(sender As Object, e As EventArgs) Handles btnButton10.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton11_MouseDown(sender As Object, e As EventArgs) Handles btnButton11.MouseDown
        ScrnTitle = btnButton11.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&HB)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton11_MouseUp(sender As Object, e As EventArgs) Handles btnButton11.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton12_MouseDown(sender As Object, e As EventArgs) Handles btnButton12.MouseDown
        ScrnTitle = btnButton12.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&HC)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton12_MouseUp(sender As Object, e As EventArgs) Handles btnButton12.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

    Private Sub btnButton13_MouseDown(sender As Object, e As EventArgs) Handles btnButton13.MouseDown
        ScrnTitle = btnButton13.Text
        Screen.Send(&H14)
        Screen.Send(&H4)
        Screen.Send(&HD)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton13_MouseUp(sender As Object, e As EventArgs) Handles btnButton13.MouseUp
        Screen.Send(&H14)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub

End Class