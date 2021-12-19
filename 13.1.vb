Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A(9), i, j, sum, max, n As Integer
        Dim str1, str2, str3 As String
        str1 = ""
        str2 = ""
        str3 = ""
        sum = 0
        For i = 0 To 9
            A(i) = Int(Rnd() * 100)
            str1 = str1 & A(i) & " "
        Next i
        Label1.Text = str1
        n = A(0)
        For i = 0 To 8
            A(i) = A(i + 1)
            str3 = str3 & A(i) & " "
        Next i
        str3 = str3 & n
        Label3.Text = str3
        For i = 0 To 9
            sum = sum + A(i)
        Next i
        str2 = str2 & sum & " "
        For i = 0 To 9
            For j = 0 To (8 - i)
                If A(j) < A(j + 1) Then
                    max = A(j)
                    A(j) = A(j + 1)
                    A(j + 1) = max
                End If
            Next j
        Next i
        str2 = str2 & A(0) & " " & A(9) & " " & sum / 10
        Label2.Text = str2
    End Sub
End Class
