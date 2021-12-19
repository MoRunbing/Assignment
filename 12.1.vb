Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, n As Integer, s As Single
        n = InputBox("输入任一正整数", "输入对话框")
        s = 0
        For i = 1 To n Step 1
            s = s + 1 / (i * (i + 1))
        Next
        MsgBox(s)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim I As Integer, S As Single
        S = 0
        I = 1
        Do While I * (I + 1) <= 10 ^ 6
            S = S + 1 / (I * (I + 1))
            I = I + 1
        Loop
        MsgBox(S)
    End Sub
End Class
