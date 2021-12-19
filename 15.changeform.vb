Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Height = TextBox4.Text
        Me.Width = TextBox2.Text
        Me.Location = New Point(TextBox1.Text, TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Font = New Font(TextBox5.Text, TextBox6.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.FromArgb(TextBox7.Text, TextBox8.Text, TextBox9.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case True
            Case CheckBox1.Checked = True And CheckBox2.Checked = False
                Me.Font = New Font("宋体", 10, FontStyle.Bold)
            Case CheckBox2.Checked = True And CheckBox1.Checked = False
                Me.Font = New Font("宋体", 10, FontStyle.Italic)
            Case CheckBox1.Checked And CheckBox2.Checked
                Me.Font = New Font("宋体", 10, FontStyle.Bold Or FontStyle.Italic)
            Case CheckBox1.Checked = False And CheckBox2.Checked = False
                Me.Font = New Font("宋体", 10, FontStyle.Regular)
        End Select
    End Sub
End Class
