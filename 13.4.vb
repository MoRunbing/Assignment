Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, j As Integer
        n = TextBox1.Text
        i = n Mod 8
        j = (n - (n Mod 8)) / 4
        If i <= 4 Then
            Label1.Text = "第" & j & "行"
            Label2.Text = "第" & i & "列"
        Else
            Label1.Text = "第" & j + 1 & "行"
            Label2.Text = "第" & 9 - i & "列"
        End If
    End Sub
End Class
