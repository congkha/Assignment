<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.Mnsmenu = New System.Windows.Forms.MenuStrip()
        Me.Mnihethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnithoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mniquanlysanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnithemsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnichitietsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mninhaphang = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnithongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ptbgiaodien1 = New System.Windows.Forms.PictureBox()
        Me.Ptbgiaodien2 = New System.Windows.Forms.PictureBox()
        Me.Sttten = New System.Windows.Forms.StatusStrip()
        Me.Stt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Mnsmenu.SuspendLayout()
        CType(Me.Ptbgiaodien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ptbgiaodien2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sttten.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mnsmenu
        '
        Me.Mnsmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnihethong, Me.Mniquanlysanpham, Me.Mnithongtin})
        Me.Mnsmenu.Location = New System.Drawing.Point(0, 0)
        Me.Mnsmenu.Name = "Mnsmenu"
        Me.Mnsmenu.Size = New System.Drawing.Size(752, 24)
        Me.Mnsmenu.TabIndex = 0
        Me.Mnsmenu.Text = "MenuStrip1"
        '
        'Mnihethong
        '
        Me.Mnihethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnithoat})
        Me.Mnihethong.Name = "Mnihethong"
        Me.Mnihethong.Size = New System.Drawing.Size(72, 20)
        Me.Mnihethong.Text = "Hệ Thống"
        '
        'Mnithoat
        '
        Me.Mnithoat.Name = "Mnithoat"
        Me.Mnithoat.Size = New System.Drawing.Size(152, 22)
        Me.Mnithoat.Text = "Thóat"
        '
        'Mniquanlysanpham
        '
        Me.Mniquanlysanpham.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnithemsp, Me.Mnichitietsp, Me.Mninhaphang})
        Me.Mniquanlysanpham.Name = "Mniquanlysanpham"
        Me.Mniquanlysanpham.Size = New System.Drawing.Size(119, 20)
        Me.Mniquanlysanpham.Text = "Quản Lý Sản Phẩm"
        '
        'Mnithemsp
        '
        Me.Mnithemsp.Name = "Mnithemsp"
        Me.Mnithemsp.Size = New System.Drawing.Size(171, 22)
        Me.Mnithemsp.Text = "Thêm Sản Phẩm"
        '
        'Mnichitietsp
        '
        Me.Mnichitietsp.Name = "Mnichitietsp"
        Me.Mnichitietsp.Size = New System.Drawing.Size(171, 22)
        Me.Mnichitietsp.Text = "Chi Tiết Sản Phẩm"
        '
        'Mninhaphang
        '
        Me.Mninhaphang.Name = "Mninhaphang"
        Me.Mninhaphang.Size = New System.Drawing.Size(171, 22)
        Me.Mninhaphang.Text = "Nhập Hàng"
        '
        'Mnithongtin
        '
        Me.Mnithongtin.Name = "Mnithongtin"
        Me.Mnithongtin.Size = New System.Drawing.Size(74, 20)
        Me.Mnithongtin.Text = "Thông Tin"
        '
        'Ptbgiaodien1
        '
        Me.Ptbgiaodien1.Image = CType(resources.GetObject("Ptbgiaodien1.Image"), System.Drawing.Image)
        Me.Ptbgiaodien1.Location = New System.Drawing.Point(39, 36)
        Me.Ptbgiaodien1.Name = "Ptbgiaodien1"
        Me.Ptbgiaodien1.Size = New System.Drawing.Size(169, 339)
        Me.Ptbgiaodien1.TabIndex = 1
        Me.Ptbgiaodien1.TabStop = False
        '
        'Ptbgiaodien2
        '
        Me.Ptbgiaodien2.Image = CType(resources.GetObject("Ptbgiaodien2.Image"), System.Drawing.Image)
        Me.Ptbgiaodien2.Location = New System.Drawing.Point(204, 36)
        Me.Ptbgiaodien2.Name = "Ptbgiaodien2"
        Me.Ptbgiaodien2.Size = New System.Drawing.Size(548, 435)
        Me.Ptbgiaodien2.TabIndex = 2
        Me.Ptbgiaodien2.TabStop = False
        '
        'Sttten
        '
        Me.Sttten.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Stt})
        Me.Sttten.Location = New System.Drawing.Point(0, 543)
        Me.Sttten.Name = "Sttten"
        Me.Sttten.Size = New System.Drawing.Size(752, 22)
        Me.Sttten.TabIndex = 3
        Me.Sttten.Text = "StatusStrip1"
        '
        'Stt
        '
        Me.Stt.Name = "Stt"
        Me.Stt.Size = New System.Drawing.Size(209, 17)
        Me.Stt.Text = "Sinh viên : Huỳnh Công Khả - PS02033"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 382)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 158)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 565)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Sttten)
        Me.Controls.Add(Me.Ptbgiaodien2)
        Me.Controls.Add(Me.Ptbgiaodien1)
        Me.Controls.Add(Me.Mnsmenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Mnsmenu
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương Trình Quản Lý Cửa Hàng Túi Xách Nam Thời Trang  C.K Shop"
        Me.Mnsmenu.ResumeLayout(False)
        Me.Mnsmenu.PerformLayout()
        CType(Me.Ptbgiaodien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ptbgiaodien2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sttten.ResumeLayout(False)
        Me.Sttten.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mnsmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents Mnihethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnithoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mniquanlysanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnithongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ptbgiaodien1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ptbgiaodien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Sttten As System.Windows.Forms.StatusStrip
    Friend WithEvents Stt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Mnithemsp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnichitietsp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mninhaphang As System.Windows.Forms.ToolStripMenuItem
End Class
