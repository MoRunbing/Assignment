Public Class Form1
    Private Sub Buttom1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C, Delta, x1, x2 As Single
        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text
        Delta = B ^ 2 - 4 * A * C
        If Delta >= 0 Then
            x1 = (-B + Math.Sqrt(Delta)) / (2 * A)
            x2 = (-B - Math.Sqrt(Delta)) / (2 * A)
            TextBox4.Text = Format(x1, "0.###")
            TextBox5.Text = Format(x2, "0.###")
        Else
            MsgBox("方程无实根")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A, B, C, Delta, x1, x2 As Single
        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text
        Delta = B ^ 2 - 4 * A * C
        Select Case Delta
            Case Delta >= 0
                x1 = (-B + Math.Sqrt(Delta)) / (2 * A) And
                x2 = (-B - Math.Sqrt(Delta)) / (2 * A) And
                TextBox4.Text = Format(x1, "0.###") And
                TextBox5.Text = Format(x2, "0.###")
            Case Delta < 0
                MsgBox("wu")
        End Select
    End Sub
End Class
