Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Frmthemsp
    Dim connect As String = "workstation id=ps02033.mssql.somee.com;packet size=4096;user id=congkhahcps02033_SQLLogin_1;pwd=dhveqhol5m;data source=ps02033.mssql.somee.com;persist security info=False;initial catalog=ps02033"
    Dim connect1 As New SqlConnection(connect)
    Public Sub LoadData()
        'mã điền vào tiêu đề'
        Dim getdata As New SqlDataAdapter("Select * From San_Pham", connect1)
        Dim tb As New DataTable
        Try
            getdata.Fill(tb)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'thực thi'
        drvds.DataSource = tb
        connect1.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblloaisp.Click

    End Sub


    ' Sự kiện load form thêm sp
    Private Sub Frmthemsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect1.Open()
        Me.LoadData()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Txtloaisp_TextChanged(sender As Object, e As EventArgs) Handles Txtsoluong.TextChanged

    End Sub


    Private Sub Lstdanhsachsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstdanhsachsp.Click

    End Sub

    Private Sub Lstdanhsachsp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstdanhsachsp.SelectedIndexChanged


    End Sub

    Private Sub Btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsua.Click
        Dim thaydoi As String = "update San_Pham set ten_sp = ten_sp, don_gia = don_gia, so_luong = so_luong Where ma_sp = ma_sp "
        connect1.Open()
        Dim cmdsql As New SqlCommand(thaydoi, connect1)
        Try
            cmdsql.Parameters.AddWithValue("ma_sp", Txtmasp.Text)
            cmdsql.Parameters.AddWithValue("ten_sp", Txttensp.Text)
            cmdsql.Parameters.AddWithValue("don_gia", Convert.ToInt32(Txtdongia.Text))
            cmdsql.Parameters.AddWithValue("so_luong", Convert.ToInt32(Txtsoluong.Text))
            cmdsql.Parameters.AddWithValue("chitiet_sp", Txtchitiet.Text)
            cmdsql.ExecuteNonQuery()
            connect1.Close()
        Catch ex As Exception
            MessageBox.Show("Chỉnh sửa thành công")

        End Try
        LoadData()




    End Sub
    ' sự kiện button xóa : xóa dòng dữ liệu đang chọn khỏi listview

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim xoa As String = " Delete from San_Pham Where ma_sp = ma_sp"
        connect1.Open()
        Dim cmdsql As New SqlCommand(xoa, connect1)
        Try
            cmdsql.Parameters.AddWithValue("ma_sp", Txtmasp.Text)
            cmdsql.ExecuteNonQuery()
            connect1.Close()
        Catch ex As Exception
            MessageBox.Show("Thực hiện xóa thành công")

        End Try
        LoadData()


    End Sub

    Private Sub Btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click

        Me.Close()

    End Sub
    Dim tenfile As String = "" 'biến lưu tên file hình ảnh

    Private Sub Ptbthemsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ptbthemsp.Click


    End Sub






    Private Sub Btnthem_Click(sender As Object, e As EventArgs) Handles Btnthem.Click
        Dim them As String = "Insert into San_Pham values(ma_sp,ten_sp,don_gia,so_luong,chitiet_sp)"
        connect1.Open()
        Dim cmdsql As New SqlCommand(them, connect1)
        Try
            cmdsql.Parameters.AddWithValue("ma_sp", Txtmasp.Text)
            cmdsql.Parameters.AddWithValue("ten_sp", Txttensp.Text)
            cmdsql.Parameters.AddWithValue("don_gia", Convert.ToInt32(Txtdongia.Text))
            cmdsql.Parameters.AddWithValue("so_luong", Convert.ToInt32(Txtsoluong.Text))
            cmdsql.Parameters.AddWithValue("chitiet_sp", Txtchitiet.Text)
            cmdsql.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Thực hiện lưu thành công")
        End Try
        LoadData()

    End Sub

    Private Sub drvds_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drvds.CellContentClick
        Dim getdatadrv As Integer = drvds.CurrentCell.RowIndex
        Txtmasp.Text = drvds.Item(0, getdatadrv).Value
        Txttensp.Text = drvds.Item(1, getdatadrv).Value
        Txtdongia.Text = drvds.Item(2, getdatadrv).Value
        Txtsoluong.Text = drvds.Item(3, getdatadrv).Value
        Txtchitiet.Text = drvds.Item(4, getdatadrv).Value
    End Sub
End Class