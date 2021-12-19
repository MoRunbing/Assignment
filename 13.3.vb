Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cs(9), x, num, i As Integer
        Randomize()
        x = Int(Rnd() * 90000000 + 10000000)
        TextBox1.Text = x

        For i = 1 To 8
            num = Mid(x, i, 1)
            cs(num) = cs(num) + 1
        Next

        TextBox2.Text = cs(0)
        TextBox3.Text = cs(1)
        TextBox4.Text = cs(2)
        TextBox5.Text = cs(3)
        TextBox6.Text = cs(4)
        TextBox7.Text = cs(5)
        TextBox8.Text = cs(6)
        TextBox9.Text = cs(7)
        TextBox10.Text = cs(8)
        TextBox11.Text = cs(9)

    End Sub
End Class