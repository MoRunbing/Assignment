Public Class Form1
    Dim Var As String, Hx As Integer, Vx As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Var = ComboBox1.Text + ComboBox2.Text + ComboBox3.Text + ComboBox4.Text
        Select Case Var
            Case Is = "肿痛轻度38度干咳"
                TextBox1.Text = "咽炎"
            Case Is = "化脓中度39度早起咳"
                TextBox1.Text = "扁桃体发炎"
            Case Is = "化脓重度40度有痰"
                TextBox1.Text = "肺炎"
            Case Else
                TextBox1.Text = "请具体描述病情"
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.ClearSelected()
    End Sub

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        ListBox1.SelectedItems.Add(ListBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
