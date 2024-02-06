Public Class Form2
    Private Sub StudentEnquaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentEnquaryToolStripMenuItem.Click
        Dim f3 As Form3 = New Enquary_Form
        ()
        f3.MdiParent = Me
        f3.Show()

    End Sub

    Private Sub ExitToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem5.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem4.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f2 As Form2 = New Form2()
        ' Dim f3 As Form3 = New Form3()
        ' f2.Hide();
        'f3.show();
    End Sub
End Class