Public Class SelectForm
    Dim Pos As Integer
    Dim lblTemp As String
    Dim i As Integer

    Private Sub SelectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Display()
        lblPage.Text = CStr(screen0(&H2C))
        lblPages.Text = CStr(screen0(&H2E))
        Pos = (screen0(&H2C) - 1) * 4

        SetForm.GetButton(0, lblTitle.Text, lblTemp, i)

        btnButton1.Visible = False
        btnButton2.Visible = False
        btnButton3.Visible = False
        btnButton4.Visible = False

        btnButton1.BackColor = Color.LightGray
        btnButton1.ForeColor = Color.Black

        btnButton2.BackColor = Color.LightGray
        btnButton2.ForeColor = Color.Black

        btnButton3.BackColor = Color.LightGray
        btnButton3.ForeColor = Color.Black

        btnButton4.BackColor = Color.LightGray
        btnButton4.ForeColor = Color.Black

        'Button 1
        btnButton1.Text = SelectInfo(Pos + 0)
        btnButton1.Visible = True

        'Button 2
        If SelectCnt > Pos + 1 Then
            btnButton2.Text = SelectInfo(Pos + 1)
            btnButton2.Visible = True
        End If

        'Button 3
        If SelectCnt > Pos + 2 Then
            btnButton3.Text = SelectInfo(Pos + 2)
            btnButton3.Visible = True
        End If

        'Button 4
        If SelectCnt > Pos + 3 Then
            btnButton4.Text = SelectInfo(Pos + 3)
            btnButton4.Visible = True
        End If

        Select Case screen0(&H30 + SelectCnt)
            Case 1
                btnButton1.Focus()
                btnButton1.BackColor = Color.Black
                btnButton1.ForeColor = Color.LightGray
            Case 2
                btnButton2.Focus()
                btnButton2.BackColor = Color.Black
                btnButton2.ForeColor = Color.LightGray
            Case 3
                btnButton3.Focus()
                btnButton3.BackColor = Color.Black
                btnButton3.ForeColor = Color.LightGray
            Case 4
                btnButton4.Focus()
                btnButton4.BackColor = Color.Black
                btnButton4.ForeColor = Color.LightGray
            Case Else
                btnButton1.Focus()
        End Select

    End Sub

    Private Sub btnButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnButton1.MouseDown
        Screen.Send(&H14)
        Screen.Send(&H7)
        Screen.Send(&H1)
        Screen.Send(&H0)
        Screen.SendMessage()
    End Sub
    Private Sub btnButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles btnButton1.MouseUp

    End Sub

    Private Sub btnButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnButton2.MouseDown

    End Sub
    Private Sub btnButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles btnButton2.MouseUp

    End Sub

    Private Sub btnButton3_MouseDown(sender As Object, e As MouseEventArgs) Handles btnButton3.MouseDown

    End Sub
    Private Sub btnButton3_MouseUp(sender As Object, e As MouseEventArgs) Handles btnButton3.MouseUp

    End Sub

    Private Sub btnButton4_MouseDown(sender As Object, e As MouseEventArgs) Handles btnButton4.MouseDown

    End Sub
    Private Sub btnButton4_MouseUp(sender As Object, e As MouseEventArgs) Handles btnButton4.MouseUp

    End Sub

    Private Sub btnUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUp.MouseDown

    End Sub
    Private Sub btnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUp.MouseUp

    End Sub

    Private Sub btnDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDown.MouseDown

    End Sub
    Private Sub btnDown_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDown.MouseUp

    End Sub

    Private Sub btnBack_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBack.MouseDown

    End Sub
    Private Sub btnBack_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBack.MouseUp

    End Sub
End Class