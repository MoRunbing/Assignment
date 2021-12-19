Public Class Form1
    Private Function sr(ByVal s As String)
        Dim a As String, i As Integer
        a = ""
        For i = 1 To Len(a) - 1
            a = Mid(s, i, 1) & a
        Next
        Return a
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, m As String
        n = TextBox1.Text
        m = sr(n)
        TextBox1.Text = m
    End Sub
End Class
