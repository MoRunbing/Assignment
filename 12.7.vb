Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String, i As Integer
        n = TextBox1.Text
        For i = 1 To Len(n)
            If Mid(n, i, 1) = " " Then
                Mid(n, i, 1) = " "
            Else
                If Asc(Mid(n, i, 1)) > 96 Then
                    Mid(n, i, 1) = Chr(219 - Asc(Mid(n, i, 1)))
                Else
                    Mid(n, i, 1) = Chr(155 - Asc(Mid(n, i, 1)))
                End If
            End If
        Next
        TextBox2.Text = n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As String, j As Integer
        m = TextBox2.Text
        For j = 1 To Len(m)
            If Mid(m, j, 1) = " " Then
                Mid(m, j, 1) = " "
            Else
                If Asc(Mid(m, j, 1)) > 96 Then
                    Mid(m, j, 1) = Chr(219 - Asc(Mid(m, j, 1)))
                Else
                    Mid(m, j, 1) = Chr(155 - Asc(Mid(m, j, 1)))
                End If
            End If
        Next
        TextBox3.Text = m
    End Sub
End Class
