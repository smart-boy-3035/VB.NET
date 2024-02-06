Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        If x > y Then
            Label3.Text = x & " is greatest number "
        Else
            Label3.Text = y & " is greatest number "
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        If x < y Then
            Label3.Text = x & " is smallest number "
        Else
            Label3.Text = y & " is smallest number "
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x, y As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        If x = y Then
            Label3.Text = "This is equal number "
        Else
            Label3.Text = "This is not equal number "
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f1 As Form1 = New Form1()
        Dim f2 As Form2 = New Form2()
        Me.Hide()
        f2.Show()
    End Sub
    Public X As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        X = InputBox("Enter your name : ")
        MessageBox.Show("Hello!! Welcome to my Application")
        MessageBox.Show("Hi !  " & x)

    End Sub
End Class
