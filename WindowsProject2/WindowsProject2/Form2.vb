Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f1 As Form1 = New Form1()
        'Dim f2 As Form2 = New Form2()
        Me.Hide()
        f1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(TextBox3.Text) >= 18 Then
            Label3.Text = "Your name is : " & TextBox1.Text & " Your age is : " & TextBox3.Text & "you are eligible for vote"
        Else
            Label3.Text = "Your name is : " & TextBox1.Text & " Your age is : " & TextBox3.Text & "you are not eligible for vote"
        End If
    End Sub
End Class