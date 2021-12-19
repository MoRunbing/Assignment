Public Class Form1
    Private Sub Aa(ByRef a As Integer, ByRef sum As Single)
        Dim n As Single, i, j As Integer
        sum = 0
        n = 1
        For i = 2 To a Step 2
            For j = 1 To i
                n = n * j
            Next j
            sum = sum + n
        Next i
    End Sub
    Private Function Bb(ByVal b As Single) As Single
        Dim sum, n As Single, i, j As Integer
        sum = 0
        n = 1
        For i = 2 To b Step 2
            For j = 1 To i
                n = n * j
            Next j
            sum = sum + n
        Next i
        Return sum
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Integer, d As Single
        c = TextBox1.Text
        If c Mod 2 = 1 Then
            Label2.Text = "输入的数不是偶数"
        Else
            Aa(c, d)
            Label2.Text = d
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As Integer
        c = TextBox1.Text
        If c Mod 2 = 1 Then
            Label3.Text = "输入的数不是偶数"
        Else
            Label3.Text = Bb(c)
        End If
    End Sub
End Class
