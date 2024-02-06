Public Class Form1

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y, z As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        z = x * y
        Label4.Text = "Multiply = " & z
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        z = x + y
        Label4.Text = "Sum = " & z

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x, y, z As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        z = x - y
        Label4.Text = "Subtract = " & z
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim x, y, z As Integer
        y = Convert.ToInt32(TextBox2.Text)
        If y = 0 Then
            Label4.Text = "Can't Divide by zero"
        Else
            x = Convert.ToInt32(TextBox1.Text)
            z = x / y
            Label4.Text = "Quotient : " & z

        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Application.Exit()

    End Sub
End Class
