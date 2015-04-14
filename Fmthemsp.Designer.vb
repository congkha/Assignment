<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmthemsp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmthemsp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ptbthemsp = New System.Windows.Forms.PictureBox()
        Me.Lblxuatxu = New System.Windows.Forms.Label()
        Me.Txtchitiet = New System.Windows.Forms.TextBox()
        Me.Lblloaisp = New System.Windows.Forms.Label()
        Me.Txtsoluong = New System.Windows.Forms.TextBox()
        Me.Txtdongia = New System.Windows.Forms.TextBox()
        Me.Lblhangsx = New System.Windows.Forms.Label()
        Me.Lbltensp = New System.Windows.Forms.Label()
        Me.Txttensp = New System.Windows.Forms.TextBox()
        Me.Txtmasp = New System.Windows.Forms.TextBox()
        Me.Lblmasp = New System.Windows.Forms.Label()
        Me.Grbdanhsachsp = New System.Windows.Forms.GroupBox()
        Me.Btnthoat = New System.Windows.Forms.Button()
        Me.Btnxoa = New System.Windows.Forms.Button()
        Me.Btnsua = New System.Windows.Forms.Button()
        Me.Btnthem = New System.Windows.Forms.Button()
        Me.Lstdanhsachsp = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ofdhinhanh = New System.Windows.Forms.OpenFileDialog()
        Me.drvds = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ptbthemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbdanhsachsp.SuspendLayout()
        CType(Me.drvds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.Ptbthemsp)
        Me.GroupBox1.Controls.Add(Me.Lblxuatxu)
        Me.GroupBox1.Controls.Add(Me.Txtchitiet)
        Me.GroupBox1.Controls.Add(Me.Lblloaisp)
        Me.GroupBox1.Controls.Add(Me.Txtsoluong)
        Me.GroupBox1.Controls.Add(Me.Txtdongia)
        Me.GroupBox1.Controls.Add(Me.Lblhangsx)
        Me.GroupBox1.Controls.Add(Me.Lbltensp)
        Me.GroupBox1.Controls.Add(Me.Txttensp)
        Me.GroupBox1.Controls.Add(Me.Txtmasp)
        Me.GroupBox1.Controls.Add(Me.Lblmasp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thôn tin sản phẩm"
        '
        'Ptbthemsp
        '
        Me.Ptbthemsp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ptbthemsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ptbthemsp.Image = CType(resources.GetObject("Ptbthemsp.Image"), System.Drawing.Image)
        Me.Ptbthemsp.Location = New System.Drawing.Point(315, 23)
        Me.Ptbthemsp.Name = "Ptbthemsp"
        Me.Ptbthemsp.Size = New System.Drawing.Size(179, 140)
        Me.Ptbthemsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ptbthemsp.TabIndex = 1
        Me.Ptbthemsp.TabStop = False
        '
        'Lblxuatxu
        '
        Me.Lblxuatxu.AutoSize = True
        Me.Lblxuatxu.Location = New System.Drawing.Point(6, 159)
        Me.Lblxuatxu.Name = "Lblxuatxu"
        Me.Lblxuatxu.Size = New System.Drawing.Size(50, 15)
        Me.Lblxuatxu.TabIndex = 9
        Me.Lblxuatxu.Text = "Chi tiết :"
        '
        'Txtchitiet
        '
        Me.Txtchitiet.Location = New System.Drawing.Point(110, 153)
        Me.Txtchitiet.Name = "Txtchitiet"
        Me.Txtchitiet.Size = New System.Drawing.Size(149, 21)
        Me.Txtchitiet.TabIndex = 8
        '
        'Lblloaisp
        '
        Me.Lblloaisp.AutoSize = True
        Me.Lblloaisp.Location = New System.Drawing.Point(6, 126)
        Me.Lblloaisp.Name = "Lblloaisp"
        Me.Lblloaisp.Size = New System.Drawing.Size(62, 15)
        Me.Lblloaisp.TabIndex = 7
        Me.Lblloaisp.Text = "Số lượng :"
        '
        'Txtsoluong
        '
        Me.Txtsoluong.Location = New System.Drawing.Point(110, 120)
        Me.Txtsoluong.Name = "Txtsoluong"
        Me.Txtsoluong.Size = New System.Drawing.Size(149, 21)
        Me.Txtsoluong.TabIndex = 6
        '
        'Txtdongia
        '
        Me.Txtdongia.Location = New System.Drawing.Point(110, 87)
        Me.Txtdongia.Name = "Txtdongia"
        Me.Txtdongia.Size = New System.Drawing.Size(149, 21)
        Me.Txtdongia.TabIndex = 5
        '
        'Lblhangsx
        '
        Me.Lblhangsx.AutoSize = True
        Me.Lblhangsx.Location = New System.Drawing.Point(6, 93)
        Me.Lblhangsx.Name = "Lblhangsx"
        Me.Lblhangsx.Size = New System.Drawing.Size(56, 15)
        Me.Lblhangsx.TabIndex = 4
        Me.Lblhangsx.Text = "Đơn giá :"
        '
        'Lbltensp
        '
        Me.Lbltensp.AutoSize = True
        Me.Lbltensp.Location = New System.Drawing.Point(6, 58)
        Me.Lbltensp.Name = "Lbltensp"
        Me.Lbltensp.Size = New System.Drawing.Size(95, 15)
        Me.Lbltensp.TabIndex = 3
        Me.Lbltensp.Text = "Tên Sản Phẩm :"
        '
        'Txttensp
        '
        Me.Txttensp.Location = New System.Drawing.Point(110, 55)
        Me.Txttensp.Name = "Txttensp"
        Me.Txttensp.Size = New System.Drawing.Size(149, 21)
        Me.Txttensp.TabIndex = 2
        '
        'Txtmasp
        '
        Me.Txtmasp.Location = New System.Drawing.Point(110, 23)
        Me.Txtmasp.Name = "Txtmasp"
        Me.Txtmasp.Size = New System.Drawing.Size(149, 21)
        Me.Txtmasp.TabIndex = 1
        '
        'Lblmasp
        '
        Me.Lblmasp.AutoSize = True
        Me.Lblmasp.Location = New System.Drawing.Point(6, 26)
        Me.Lblmasp.Name = "Lblmasp"
        Me.Lblmasp.Size = New System.Drawing.Size(92, 15)
        Me.Lblmasp.TabIndex = 0
        Me.Lblmasp.Text = "Mã Sản Phẩm :"
        '
        'Grbdanhsachsp
        '
        Me.Grbdanhsachsp.BackColor = System.Drawing.Color.LemonChiffon
        Me.Grbdanhsachsp.Controls.Add(Me.drvds)
        Me.Grbdanhsachsp.Controls.Add(Me.Btnthoat)
        Me.Grbdanhsachsp.Controls.Add(Me.Btnxoa)
        Me.Grbdanhsachsp.Controls.Add(Me.Btnsua)
        Me.Grbdanhsachsp.Controls.Add(Me.Btnthem)
        Me.Grbdanhsachsp.Controls.Add(Me.Lstdanhsachsp)
        Me.Grbdanhsachsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grbdanhsachsp.ForeColor = System.Drawing.Color.DarkCyan
        Me.Grbdanhsachsp.Location = New System.Drawing.Point(23, 249)
        Me.Grbdanhsachsp.Name = "Grbdanhsachsp"
        Me.Grbdanhsachsp.Size = New System.Drawing.Size(520, 277)
        Me.Grbdanhsachsp.TabIndex = 1
        Me.Grbdanhsachsp.TabStop = False
        Me.Grbdanhsachsp.Text = "Danh sách sản phẩm"
        '
        'Btnthoat
        '
        Me.Btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.Location = New System.Drawing.Point(369, 206)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.Btnthoat.TabIndex = 4
        Me.Btnthoat.Text = "Thoát"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'Btnxoa
        '
        Me.Btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.Location = New System.Drawing.Point(254, 206)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.Btnxoa.TabIndex = 3
        Me.Btnxoa.Text = "Xóa"
        Me.Btnxoa.UseVisualStyleBackColor = True
        '
        'Btnsua
        '
        Me.Btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsua.Location = New System.Drawing.Point(138, 206)
        Me.Btnsua.Name = "Btnsua"
        Me.Btnsua.Size = New System.Drawing.Size(75, 23)
        Me.Btnsua.TabIndex = 2
        Me.Btnsua.Text = "Sửa"
        Me.Btnsua.UseVisualStyleBackColor = True
        '
        'Btnthem
        '
        Me.Btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.Location = New System.Drawing.Point(29, 206)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(75, 23)
        Me.Btnthem.TabIndex = 1
        Me.Btnthem.Text = "Thêm"
        Me.Btnthem.UseVisualStyleBackColor = True
        '
        'Lstdanhsachsp
        '
        Me.Lstdanhsachsp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Lstdanhsachsp.Location = New System.Drawing.Point(9, 20)
        Me.Lstdanhsachsp.Name = "Lstdanhsachsp"
        Me.Lstdanhsachsp.Size = New System.Drawing.Size(505, 180)
        Me.Lstdanhsachsp.TabIndex = 0
        Me.Lstdanhsachsp.UseCompatibleStateImageBehavior = False
        Me.Lstdanhsachsp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã SP"
        Me.ColumnHeader1.Width = 61
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên sản phẩm"
        Me.ColumnHeader2.Width = 118
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hãng sản xuất"
        Me.ColumnHeader3.Width = 113
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Loại sản phẩm"
        Me.ColumnHeader4.Width = 116
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Xuất xứ"
        Me.ColumnHeader5.Width = 85
        '
        'Ofdhinhanh
        '
        Me.Ofdhinhanh.FileName = "OpenFileDialog1"
        '
        'drvds
        '
        Me.drvds.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.drvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drvds.Location = New System.Drawing.Point(0, 0)
        Me.drvds.Name = "drvds"
        Me.drvds.Size = New System.Drawing.Size(520, 200)
        Me.drvds.TabIndex = 5
        '
        'Frmthemsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(623, 540)
        Me.Controls.Add(Me.Grbdanhsachsp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frmthemsp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Sản Phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ptbthemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbdanhsachsp.ResumeLayout(False)
        CType(Me.drvds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblloaisp As System.Windows.Forms.Label
    Friend WithEvents Txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents Txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Lblhangsx As System.Windows.Forms.Label
    Friend WithEvents Lbltensp As System.Windows.Forms.Label
    Friend WithEvents Txttensp As System.Windows.Forms.TextBox
    Friend WithEvents Txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Lblmasp As System.Windows.Forms.Label
    Friend WithEvents Ptbthemsp As System.Windows.Forms.PictureBox
    Friend WithEvents Lblxuatxu As System.Windows.Forms.Label
    Friend WithEvents Txtchitiet As System.Windows.Forms.TextBox
    Friend WithEvents Grbdanhsachsp As System.Windows.Forms.GroupBox
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnsua As System.Windows.Forms.Button
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents Lstdanhsachsp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ofdhinhanh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents drvds As System.Windows.Forms.DataGridView
End Class
