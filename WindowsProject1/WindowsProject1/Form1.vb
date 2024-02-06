Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim f1 As Form1 = New Form1()
        Dim f2 As Form2 = New Form2()
        If TextBox1.Text = "Smart-Boy-3035" And MaskedTextBox1.Text = "732500" Then
            MessageBox.Show("You are valid user...." & TextBox1.Text)
            Me.Hide()
            f2.Show()
        Else
            MessageBox.Show("Invalid User Name And Passward")
            TextBox1.Text = ""
            MaskedTextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub
End Class
