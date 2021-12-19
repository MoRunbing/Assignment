Public Class Form2
    Dim x, y As Integer
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = Int(Rnd() * 600) + 1
        y = Int(Rnd() * 600) + 1
        Me.Text = "动画演示"
        Me.Height = 600
        Me.Width = 600
        BackColor = Color.DarkGreen
        PictureBox1.Height = 100
        PictureBox1.Width = 100
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\R1.jpg")
        PictureBox1.Location = New Point(x, y)
        HScrollBar1.Maximum = 1000
        HScrollBar1.Minimum = 10
        HScrollBar1.Value = 500
        Timer1.Interval = 500
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a, b As Integer
        a = Int(Rnd() * 600) + 1
        b = Int(Rnd() * 600) + 1
        PictureBox1.Location = New Point(a, b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        PictureBox1.Location = New Point(x, y)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Timer1.Interval = HScrollBar1.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class