Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim Xa As Single, Ya As Single, Xb As Single, Yb As Single, Xc As Single, Yc As Single, a As Single, b As Single, c As Single, p As Single, S As Single

        Xa = TextBox1.Text
        Ya = TextBox2.Text
        Xb = TextBox3.Text
        Yb = TextBox4.Text
        Xc = TextBox5.Text
        Yc = TextBox6.Text
        a = Math.Sqrt((Xc - Xb) ^ 2 + (Yc - Yb) ^ 2)
        b = Math.Sqrt((Xa - Xc) ^ 2 + (Ya - Yc) ^ 2)
        c = Math.Sqrt((Xa - Xb) ^ 2 + (Ya - Yb) ^ 2)
        p = (a + b + c) / 2
        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
        MsgBox(S)
    End Sub
End Class
