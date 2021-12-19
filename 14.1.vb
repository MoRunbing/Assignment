Public Class Form1
    Private Sub AreaSub1(ByVal R As Single, ByVal s As Single)
        Const Pi As Single = 3.1416
        s = Pi * R ^ (2)
    End Sub

    Private Sub AreaSub2(ByVal R As Single, ByVal s As Single)
        Const Pi As Single = 3.1416
        s = Pi * R ^ (2)
        MsgBox("圆的面积是：" & s)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c, s As Single
        c = InputBox("请输入一个数"， "圆面积"， 100， 1000, 1000)
        Call AreaSub1(c, s)
        MsgBox("圆的面积是：" & s)
    End Sub
End Class