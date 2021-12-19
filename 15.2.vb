Public Class Form1
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        PictureBox2.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\FACE04.ico")
        PictureBox3.Image = Image.FromFile("D:\Slides\医信\实验27-28素材\misc23.ico")
        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 0 Then
            PictureBox1.Image = PictureBox2.Image
            i = 1
        Else
            PictureBox1.Image = PictureBox3.Image
            i = 0
        End If

        If Label1.Left > 0 Then
            Label1.Left = Label1.Left - 10
        Else
            Label1.Left = Me.Width
            End If
    End Sub
End Class
