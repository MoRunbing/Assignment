Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim a As String, b As Boolean
        a = InputBox("输入任一字符串", "输入对话框")
        b = InStr(a, "a")
        MsgBox("字符串的长度是：" & Len(a) & Chr(10) & "字符串是否包含a ：" & b)

    End Sub
End Class
