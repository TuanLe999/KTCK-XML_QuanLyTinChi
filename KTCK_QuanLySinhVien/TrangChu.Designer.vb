<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrangChu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrangChu))
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Class_cbb = New System.Windows.Forms.ComboBox()
        Me.them_btn = New System.Windows.Forms.Button()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbb_timKiem = New System.Windows.Forms.ComboBox()
        Me.txt_timKiem = New System.Windows.Forms.TextBox()
        Me.lamMoi_btn = New System.Windows.Forms.Button()
        Me.tkb_btn = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStudents
        '
        Me.dgvStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(40, 244)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.Size = New System.Drawing.Size(1139, 395)
        Me.dgvStudents.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1471, 129)
        Me.Panel1.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(560, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(450, 40)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(186, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "KHOA CÔNG NGHỆ SỐ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(186, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(186, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐẠI HỌC ĐÀ NẴNG"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.KTCK_QuanLySinhVien.My.Resources.Resources.logo_trường
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(40, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 128)
        Me.Panel2.TabIndex = 0
        '
        'Class_cbb
        '
        Me.Class_cbb.FormattingEnabled = True
        Me.Class_cbb.Location = New System.Drawing.Point(1011, 191)
        Me.Class_cbb.Name = "Class_cbb"
        Me.Class_cbb.Size = New System.Drawing.Size(121, 24)
        Me.Class_cbb.TabIndex = 42
        '
        'them_btn
        '
        Me.them_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.them_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.them_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.them_btn.Image = CType(resources.GetObject("them_btn.Image"), System.Drawing.Image)
        Me.them_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.them_btn.Location = New System.Drawing.Point(181, 673)
        Me.them_btn.Name = "them_btn"
        Me.them_btn.Size = New System.Drawing.Size(143, 59)
        Me.them_btn.TabIndex = 34
        Me.them_btn.Text = "Thêm mới"
        Me.them_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.them_btn.UseVisualStyleBackColor = False
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.Delete_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Delete_btn.Image = CType(resources.GetObject("Delete_btn.Image"), System.Drawing.Image)
        Me.Delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete_btn.Location = New System.Drawing.Point(640, 673)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(113, 59)
        Me.Delete_btn.TabIndex = 35
        Me.Delete_btn.Text = "Xóa"
        Me.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.update_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.update_btn.Image = CType(resources.GetObject("update_btn.Image"), System.Drawing.Image)
        Me.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_btn.Location = New System.Drawing.Point(424, 673)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(116, 59)
        Me.update_btn.TabIndex = 38
        Me.update_btn.Text = "Sửa"
        Me.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "TÌM KIẾM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(915, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "LỚP"
        '
        'cbb_timKiem
        '
        Me.cbb_timKiem.FormattingEnabled = True
        Me.cbb_timKiem.Items.AddRange(New Object() {"MSV", "Ten", "SDT"})
        Me.cbb_timKiem.Location = New System.Drawing.Point(446, 188)
        Me.cbb_timKiem.Name = "cbb_timKiem"
        Me.cbb_timKiem.Size = New System.Drawing.Size(121, 24)
        Me.cbb_timKiem.TabIndex = 45
        '
        'txt_timKiem
        '
        Me.txt_timKiem.Location = New System.Drawing.Point(610, 188)
        Me.txt_timKiem.Name = "txt_timKiem"
        Me.txt_timKiem.Size = New System.Drawing.Size(189, 22)
        Me.txt_timKiem.TabIndex = 46
        '
        'lamMoi_btn
        '
        Me.lamMoi_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.lamMoi_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lamMoi_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lamMoi_btn.Image = CType(resources.GetObject("lamMoi_btn.Image"), System.Drawing.Image)
        Me.lamMoi_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lamMoi_btn.Location = New System.Drawing.Point(63, 169)
        Me.lamMoi_btn.Name = "lamMoi_btn"
        Me.lamMoi_btn.Size = New System.Drawing.Size(122, 59)
        Me.lamMoi_btn.TabIndex = 47
        Me.lamMoi_btn.Text = "Làm mới"
        Me.lamMoi_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lamMoi_btn.UseVisualStyleBackColor = False
        '
        'tkb_btn
        '
        Me.tkb_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.tkb_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkb_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tkb_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tkb_btn.Location = New System.Drawing.Point(864, 673)
        Me.tkb_btn.Name = "tkb_btn"
        Me.tkb_btn.Size = New System.Drawing.Size(190, 59)
        Me.tkb_btn.TabIndex = 48
        Me.tkb_btn.Text = "Xem thời khóa biểu"
        Me.tkb_btn.UseVisualStyleBackColor = False
        '
        'TrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 828)
        Me.Controls.Add(Me.tkb_btn)
        Me.Controls.Add(Me.lamMoi_btn)
        Me.Controls.Add(Me.txt_timKiem)
        Me.Controls.Add(Me.cbb_timKiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Class_cbb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.Delete_btn)
        Me.Controls.Add(Me.them_btn)
        Me.Name = "TrangChu"
        Me.Text = "TrangChu"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsSinhVien1 As dsSinhVien
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Class_cbb As ComboBox
    Friend WithEvents them_btn As Button
    Friend WithEvents Delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbb_timKiem As ComboBox
    Friend WithEvents txt_timKiem As TextBox
    Friend WithEvents lamMoi_btn As Button
    Friend WithEvents tkb_btn As Button
End Class
