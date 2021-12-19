Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer, J As Integer
        Dim Y As Boolean
        Dim K As Integer
        Dim N As String
        K = 0
        N = ""
        For I = 2 To 100
            Y = True
            For J = 2 To I - 1
                If I Mod J = 0 Then
                    Y = False
                End If
                Exit For
            Next J
            If Y Then
                N = N & " " & I
                K = K + 1
                If K Mod 5 = 0 Then N = N & Chr(10)
            End If
            End If
        Next I
        Label1.Text = N
    End Sub
End Class
