Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, n As Integer
        n = 0
        For i = 1 To 100 Step 1
            n = n + Math.Sqrt(3 * i + 5)
        Next
        MsgBox("n=" & n)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, n As Integer
        n = 0
        For i = 7 To 10 Step 1
            n = n + 4 * i / 5
        Next
        MsgBox("n=" & n)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, n As Integer
        n = 0
        i = 1
        Do While i <= 100
            n = n + Math.Sqrt(3 * i + 5)
            i = i + 1
        Loop
        MsgBox("n=" & n)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i, n As Integer
        n = 0
        i = 7
        Do While i <= 10
            n = n + 4 * i / 5
            i = i + 1
        Loop
        MsgBox("n=" & n)
    End Sub
End Class
