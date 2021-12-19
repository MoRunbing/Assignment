Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Font = New Font("楷体", 20)
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim x As Integer
        x = Len(TextBox1.Text)
        If x <> 6 Then
            TextBox1.Text = ""
            TextBox1.Focus()
            TextBox2.Clear()
            MsgBox("请重新输入病历号")
        Else
            TextBox2.Clear()
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = TextBox1.Text
        b = TextBox2.Text
        ListBox1.Items.Add(a & " " & b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        End
    End Sub
End Class
