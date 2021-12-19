Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, a(n), b As Integer
        a(1) = 1
        a(2) = 1
        n = TextBox1.Text
        For b = 3 To n
            a(b) = a(b - 1) + a(b - 2)
        Next
        TextBox2.Text = a(n)
    End Sub
End Class
