Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As String
        Dim i As Integer, j As Integer
        y = ""
        For i = 9 To 1 Step -2
            y = y & Space((9 - i) / 2)
            For j = 1 To i
                y = y & "*"
            Next j
            y = y & Chr(10)
        Next i
        Label1.Text = y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As String
        Dim i As Integer, j As Integer
        y = ""
        i = 9
        Do While i >= 1
            y = y & Space((9 - i) / 2)
            j = 1
            Do While j <= i
                y = y & "*"
                j = j + 1
            Loop
            i = i - 2
            y = y & Chr(10)
        Loop
        Label2.Text = y
    End Sub
End Class
