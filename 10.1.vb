Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim Var1 As Integer, Var2 As String
        Var1 = 12345
        Var2 = InputBox("输入Var2=", "输入对话框")
        MsgBox("Var1=" & Str(Var1) & Chr(13) & Chr(10) & Var2)


    End Sub
