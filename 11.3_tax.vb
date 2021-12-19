Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, Tax As Single
        a = TextBox1.Text
        If a <= 20000 Then
            Tax = 0.02 * a
        ElseIf a <= 50000 Then
            Tax = 400 + (a - 20000) * 0.025
        Else Tax = 1150 + 0.035 * (a - 50000)
        End If
        TextBox2.Text = Tax
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, Tax As Single
        a = TextBox1.Text
        Select Case a
            Case a <= 2000
                Tax = 0.02 * a
            Case a <= 50000
                Tax = 400 + (a - 20000) * 0.025
            Case Else
                Tax = 1150 + 0.035 * (a - 50000)
        End Select
        TextBox2.Text = Tax
    End Sub
End Class
