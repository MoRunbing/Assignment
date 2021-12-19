Public Class Form1
    Private Function ets(ByVal x As Integer)
        Dim a As Integer
        Dim s As String
        s = ""
        Do Until x = 1
            a = x Mod 2
            If a = 1 Then
                x = (x - 1) / 2
            Else
                x = x / 2
            End If
            s = s & a
        Loop
        s = StrReverse(s)
        Return s
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer
        n = Val(TextBox1.Text)
        TextBox2.Text = ets(n)
    End Sub
End Class
