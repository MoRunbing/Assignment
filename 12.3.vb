Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, n, a, b As Integer
        i = 0
        Do While i < 10
            n = InputBox("请输入一个自然数", "输入对话框")
            If n Mod 2 = 1 Then
                a = a + 1
            Else b = b + 1
            End If
            i = i + 1
        Loop
        TextBox1.Text = a
        TextBox2.Text = b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, n, a, b As Integer
        a = 0
        b = 0
        For i = 1 To 10 Step 1
            n = InputBox("请输入一个自然数", "输入对话框")
            If n Mod 2 = 1 Then
                a = a + 1
            Else
                b = b + 1
            End If
        Next
        TextBox1.Text = a
        TextBox2.Text = b
    End Sub
End Class
