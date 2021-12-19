Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim y As String
        Dim i, j, m, n As Integer
        y = ""
        For i = 1 To 5
            y = y & Space(10 - i)
            j = 1
            Do While j <= 2 * i - 1
                y = y & "*"
                j = j + 1
            Loop
            y = y & Chr(10)
        Next i
        For m = 5 To 2 Step -1
            y = y & Space(11 - m)
            For n = 1 To 2 * m - 3
                y = y & "*"
            Next n
            y = y & Chr(10)
        Next m
        Label1.text = y
    End Sub
End Class
