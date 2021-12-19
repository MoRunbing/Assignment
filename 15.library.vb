Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim num As Integer
        num = ListBox1.Items.Count
        For i = 0 To num - 1
            If ListBox1.Items(i) = "内科学" Or ListBox1.Items(i) = "外科学" Then
                MsgBox("期刊已借阅")
                Exit Sub
            End If
        Next i
        If RadioButton1.Checked = True Then
            ListBox1.Items.Add("内科学")
        ElseIf RadioButton2.Checked = True Then
            ListBox1.Items.Add("外科学")
        End If
    End Sub
End Class

