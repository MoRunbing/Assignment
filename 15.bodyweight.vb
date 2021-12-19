Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Single
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        Select Case True
            Case RadioButton1.Checked = True
                If y > x - 100 Then
                    结果.Text = "体重超标，注意饮食与运动！"
                Else
                    结果.Text = "体重正常"
                End If
            Case RadioButton2.Checked = True
                If y > x - 105 Then
                    结果.Text = "体重超标，注意饮食与运动！"
                Else
                    结果.Text = "体重正常"
                End If
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        结果.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        End
    End Sub
End Class
