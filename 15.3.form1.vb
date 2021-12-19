Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "医学图像诊阅"
        Me.WindowState = FormWindowState.Maximized
        Me.AutoScroll = True
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub 打开CtrlOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 打开CtrlOToolStripMenuItem1.Click
        PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\R1.jpg")
        PictureBox1.Size = PictureBox1.Image.Size
        PictureBox1.Refresh()
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        PictureBox1.Refresh()
    End Sub

    Private Sub 退出CtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出CtrlXToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 顺时针旋转ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 顺时针旋转ToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Size = PictureBox1.Image.Size
        PictureBox1.Refresh()
    End Sub

    Private Sub 逆时针旋转ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 逆时针旋转ToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PictureBox1.Size = PictureBox1.Image.Size
        PictureBox1.Refresh()
    End Sub

    Private Sub 水平翻转ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 水平翻转ToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Size = PictureBox1.Image.Size
        PictureBox1.Refresh()
    End Sub

    Private Sub 垂直翻转ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 垂直翻转ToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Size = PictureBox1.Image.Size
        PictureBox1.Refresh()
    End Sub

    Private Sub 放大ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 放大ToolStripMenuItem.Click
        PictureBox1.Width = PictureBox1.Width + 30
        PictureBox1.Height = PictureBox1.Height + 30
        PictureBox1.Refresh()
    End Sub

    Private Sub 缩小ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 缩小ToolStripMenuItem.Click
        PictureBox1.Width = PictureBox1.Width - 30
        PictureBox1.Height = PictureBox1.Height - 30
        PictureBox1.Refresh()
    End Sub

    Private Sub 实际像素ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 实际像素ToolStripMenuItem.Click
        PictureBox1.Size = PictureBox1.Image.Size
    End Sub

    Private Sub 按屏幕大小缩放ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 按屏幕大小缩放ToolStripMenuItem.Click
        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height
        PictureBox1.Refresh()
    End Sub

    Private Sub 动画AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 动画AToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
