
Public Class Frmdangnhap

    Private Sub Btndangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndangnhap.Click
        If Txtdangnhap.Text = "" OrElse Txtmatkhau.Text = "" Then 'Nếu ko nhập tk và mk thì
            MessageBox.Show("Xin bạn vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error) 'Hiển thị hộp thoại thông báo

            'Nếu tài khoản đăng nhập là admin và mật khẩu là 9009 thì
        ElseIf Txtdangnhap.Text = "admin" AndAlso Txtmatkhau.Text = "9009" Then
            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công vào hệ thống", "Thông báo", MessageBoxButtons.OK,
                             MessageBoxIcon.Information) ' Hiển thị hộp thoại thông báo chúc mừng đăng nhập thành công
            Me.Hide()
            frmmain.Show()

            'Nếu tài khoản đăng nhập là nhanvien và mât khẩu là 0000 thì
        ElseIf Txtdangnhap.Text = "nhanvien" AndAlso Txtmatkhau.Text = "0000" Then
            MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công vào hệ thống", "Thông báo", MessageBoxButtons.OK,
                             MessageBoxIcon.Information) ' Hiển thị hộp thoại thông báo đăng nhập thành công với vai trò nv
            Me.Hide()
            frmmain.Show()
            frmmain.Mnithemsp.Enabled = True
            frmmain.Mninhaphang.Enabled = False



        Else 'ngược lại khi đăng nhập sai mk hoặc tk
            MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK,
                             MessageBoxIcon.Error)


        End If
        'congkha1212 vừa vào đây'


    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub

    Private Sub Frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grbdangnhap_Enter(sender As Object, e As EventArgs) Handles Grbdangnhap.Enter

    End Sub
End Class
