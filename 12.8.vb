Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j, s As Integer
        Dim t, w As String
        w = ""
        For i = 1 To 9 Step 1
            For j = 1 To i Step 1
                s = j * i
                t = j.ToString() & "*" & i.ToString() & "=" & s.ToString()
                w = w & t & Space(8 - Len(t))
            Next
            w = w & Chr(10)
        Next
        Label1.Text = w
    End Sub
End Class