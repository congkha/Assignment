<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmthongtin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmthongtin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btndong = New System.Windows.Forms.Button()
        Me.Lblgv = New System.Windows.Forms.Label()
        Me.Lblms = New System.Windows.Forms.Label()
        Me.Lblten = New System.Windows.Forms.Label()
        Me.Lblbanquyen = New System.Windows.Forms.Label()
        Me.Lblphienban = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Btndong)
        Me.Panel1.Controls.Add(Me.Lblgv)
        Me.Panel1.Controls.Add(Me.Lblms)
        Me.Panel1.Controls.Add(Me.Lblten)
        Me.Panel1.Controls.Add(Me.Lblbanquyen)
        Me.Panel1.Controls.Add(Me.Lblphienban)
        Me.Panel1.Location = New System.Drawing.Point(-1, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 223)
        Me.Panel1.TabIndex = 0
        '
        'Btndong
        '
        Me.Btndong.Location = New System.Drawing.Point(148, 183)
        Me.Btndong.Name = "Btndong"
        Me.Btndong.Size = New System.Drawing.Size(75, 23)
        Me.Btndong.TabIndex = 5
        Me.Btndong.Text = "Đóng"
        Me.Btndong.UseVisualStyleBackColor = True
        '
        'Lblgv
        '
        Me.Lblgv.AutoSize = True
        Me.Lblgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblgv.Location = New System.Drawing.Point(78, 151)
        Me.Lblgv.Name = "Lblgv"
        Me.Lblgv.Size = New System.Drawing.Size(186, 18)
        Me.Lblgv.TabIndex = 4
        Me.Lblgv.Text = "GVHD: Trần Duy Phong"
        '
        'Lblms
        '
        Me.Lblms.AutoSize = True
        Me.Lblms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lblms.Location = New System.Drawing.Point(75, 120)
        Me.Lblms.Name = "Lblms"
        Me.Lblms.Size = New System.Drawing.Size(242, 18)
        Me.Lblms.TabIndex = 3
        Me.Lblms.Text = "MSSV: PS02033 - Lớp: PT9304"
        '
        'Lblten
        '
        Me.Lblten.AutoSize = True
        Me.Lblten.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lblten.Location = New System.Drawing.Point(44, 93)
        Me.Lblten.Name = "Lblten"
        Me.Lblten.Size = New System.Drawing.Size(304, 18)
        Me.Lblten.TabIndex = 2
        Me.Lblten.Text = "Lập Trình Phần Mềm : Huỳnh Công Khả"
        '
        'Lblbanquyen
        '
        Me.Lblbanquyen.AutoSize = True
        Me.Lblbanquyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbanquyen.Location = New System.Drawing.Point(75, 62)
        Me.Lblbanquyen.Name = "Lblbanquyen"
        Me.Lblbanquyen.Size = New System.Drawing.Size(203, 18)
        Me.Lblbanquyen.TabIndex = 1
        Me.Lblbanquyen.Text = "Bản quyền thuộc về KhảIT"
        '
        'Lblphienban
        '
        Me.Lblphienban.AutoSize = True
        Me.Lblphienban.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblphienban.Location = New System.Drawing.Point(113, 23)
        Me.Lblphienban.Name = "Lblphienban"
        Me.Lblphienban.Size = New System.Drawing.Size(120, 18)
        Me.Lblphienban.TabIndex = 0
        Me.Lblphienban.Text = "Phiên Bản V.1.00"
        '
        'Frmthongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(384, 316)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmthongtin"
        Me.Text = "Thôn tin phần mềm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lblgv As System.Windows.Forms.Label
    Friend WithEvents Lblms As System.Windows.Forms.Label
    Friend WithEvents Lblten As System.Windows.Forms.Label
    Friend WithEvents Lblbanquyen As System.Windows.Forms.Label
    Friend WithEvents Lblphienban As System.Windows.Forms.Label
    Friend WithEvents Btndong As System.Windows.Forms.Button
End Class
