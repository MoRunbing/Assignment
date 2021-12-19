Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A(20), m, n, i, j, max As Integer
        Dim str, nstr As String
        str = ""
        nstr = ""
        m = 0
        n = 0
        Randomize()
        For i = 1 To 20
            A(i) = Int(Rnd() * 100)
            str = str & A(i) & ","
        Next
        TextBox1.Text = str

        For i = 1 To 20
            If A(i) >= 50 Then
                m = m + 1
            End If
        Next
        TextBox2.Text = m

        For i = 1 To 20
            If A(i) <= 10 Then
                n = n + 1
            End If
        Next
        TextBox3.Text = n

        For i = 1 To 20
            For j = 1 To (20 - i)
                If A(j) < A(j + 1) Then
                    max = A(j)
                    A(j) = A(j + 1)
                    A(j + 1) = max
                End If
            Next
        Next
        For i = 1 To 20
            nstr = nstr & A(i) & ","
        Next
        TextBox4.Text = nstr
    End Sub
End Class
