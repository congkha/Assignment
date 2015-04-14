<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmdangnhap))
        Me.Lbltieude = New System.Windows.Forms.Label()
        Me.Grbdangnhap = New System.Windows.Forms.GroupBox()
        Me.Btnthoat = New System.Windows.Forms.Button()
        Me.Btndangnhap = New System.Windows.Forms.Button()
        Me.Txtmatkhau = New System.Windows.Forms.TextBox()
        Me.Txtdangnhap = New System.Windows.Forms.TextBox()
        Me.Lblmatkhau = New System.Windows.Forms.Label()
        Me.Lbltaikhoan = New System.Windows.Forms.Label()
        Me.Grbdangnhap.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbltieude
        '
        Me.Lbltieude.AutoSize = True
        Me.Lbltieude.BackColor = System.Drawing.Color.Sienna
        Me.Lbltieude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltieude.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lbltieude.Location = New System.Drawing.Point(69, 21)
        Me.Lbltieude.Name = "Lbltieude"
        Me.Lbltieude.Size = New System.Drawing.Size(210, 20)
        Me.Lbltieude.TabIndex = 0
        Me.Lbltieude.Text = "HỆ THỐNG ĐĂNG NHẬP"
        '
        'Grbdangnhap
        '
        Me.Grbdangnhap.BackColor = System.Drawing.Color.Sienna
        Me.Grbdangnhap.Controls.Add(Me.Btnthoat)
        Me.Grbdangnhap.Controls.Add(Me.Btndangnhap)
        Me.Grbdangnhap.Controls.Add(Me.Txtmatkhau)
        Me.Grbdangnhap.Controls.Add(Me.Txtdangnhap)
        Me.Grbdangnhap.Controls.Add(Me.Lblmatkhau)
        Me.Grbdangnhap.Controls.Add(Me.Lbltaikhoan)
        Me.Grbdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grbdangnhap.ForeColor = System.Drawing.Color.LimeGreen
        Me.Grbdangnhap.Location = New System.Drawing.Point(31, 61)
        Me.Grbdangnhap.Name = "Grbdangnhap"
        Me.Grbdangnhap.Size = New System.Drawing.Size(298, 178)
        Me.Grbdangnhap.TabIndex = 1
        Me.Grbdangnhap.TabStop = False
        Me.Grbdangnhap.Text = "Đăng nhập"
        '
        'Btnthoat
        '
        Me.Btnthoat.Location = New System.Drawing.Point(158, 133)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.Btnthoat.TabIndex = 5
        Me.Btnthoat.Text = "Thoát"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'Btndangnhap
        '
        Me.Btndangnhap.Location = New System.Drawing.Point(42, 133)
        Me.Btndangnhap.Name = "Btndangnhap"
        Me.Btndangnhap.Size = New System.Drawing.Size(102, 23)
        Me.Btndangnhap.TabIndex = 4
        Me.Btndangnhap.Text = "Đăng nhập"
        Me.Btndangnhap.UseVisualStyleBackColor = True
        '
        'Txtmatkhau
        '
        Me.Txtmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmatkhau.Location = New System.Drawing.Point(102, 81)
        Me.Txtmatkhau.Name = "Txtmatkhau"
        Me.Txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtmatkhau.Size = New System.Drawing.Size(146, 21)
        Me.Txtmatkhau.TabIndex = 3
        '
        'Txtdangnhap
        '
        Me.Txtdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdangnhap.Location = New System.Drawing.Point(102, 39)
        Me.Txtdangnhap.Name = "Txtdangnhap"
        Me.Txtdangnhap.Size = New System.Drawing.Size(146, 21)
        Me.Txtdangnhap.TabIndex = 2
        '
        'Lblmatkhau
        '
        Me.Lblmatkhau.AutoSize = True
        Me.Lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmatkhau.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lblmatkhau.Location = New System.Drawing.Point(25, 84)
        Me.Lblmatkhau.Name = "Lblmatkhau"
        Me.Lblmatkhau.Size = New System.Drawing.Size(53, 13)
        Me.Lblmatkhau.TabIndex = 1
        Me.Lblmatkhau.Text = "Mật Khẩu"
        '
        'Lbltaikhoan
        '
        Me.Lbltaikhoan.AutoSize = True
        Me.Lbltaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltaikhoan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbltaikhoan.Location = New System.Drawing.Point(22, 42)
        Me.Lbltaikhoan.Name = "Lbltaikhoan"
        Me.Lbltaikhoan.Size = New System.Drawing.Size(56, 13)
        Me.Lbltaikhoan.TabIndex = 0
        Me.Lbltaikhoan.Text = "Tài Khoản"
        '
        'Frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(382, 262)
        Me.Controls.Add(Me.Grbdangnhap)
        Me.Controls.Add(Me.Lbltieude)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập hệ thống"
        Me.Grbdangnhap.ResumeLayout(False)
        Me.Grbdangnhap.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbltieude As System.Windows.Forms.Label
    Friend WithEvents Grbdangnhap As System.Windows.Forms.GroupBox
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents Btndangnhap As System.Windows.Forms.Button
    Friend WithEvents Txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents Txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents Lbltaikhoan As System.Windows.Forms.Label

End Class
