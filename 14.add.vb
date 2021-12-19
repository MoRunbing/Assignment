Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, n As Integer, result As Double
        x = TextBox1.Text
        n = ComboBox1.Text
        trans(x, result, n)
        TextBox2.Text = result

    End Sub
    Private Sub trans(ByVal x As Short, ByRef result As String, ByVal n As Integer)
        Dim r As Integer
        result = ""
        Do Until x = 0
            r = x Mod n
            If n = 16 Then
                If r >= 10 And r <= 15 Then
                    result = Chr((r - 10) + 65) & result
                Else
                    result = r & result
                End If
                result = r & result
            End If
        Loop
    End Sub


End Class