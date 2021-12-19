Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("中性粒细胞")
        ComboBox1.Items.Add("嗜酸性粒细胞")
        ComboBox1.Items.Add("嗜碱性粒细胞")
        ComboBox1.Items.Add("小淋巴细胞")
        ComboBox1.Items.Add("中淋巴细胞")
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = My.Resources.中性粒细胞
            Case 1
                PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\嗜酸性粒细胞.jpg")
            Case 2
                PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\嗜碱性粒细胞.jpg")
            Case 3
                PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\小淋巴细胞.jpg")
            Case 4
                PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\中淋巴细胞.jpg")
        End Select
    End Sub
End Class