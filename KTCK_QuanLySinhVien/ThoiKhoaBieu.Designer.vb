<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThoiKhoaBieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThoiKhoaBieu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.quayLai_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TKB_dgv = New System.Windows.Forms.DataGridView()
        Me.msv_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tenSV_label = New System.Windows.Forms.Label()
        Me.sl_label = New System.Windows.Forms.Label()
        Me.Tc_label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dkHP_btn = New System.Windows.Forms.Button()
        Me.huyHP_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.TKB_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.quayLai_btn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 101)
        Me.Panel1.TabIndex = 72
        '
        'quayLai_btn
        '
        Me.quayLai_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.quayLai_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quayLai_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.quayLai_btn.Image = CType(resources.GetObject("quayLai_btn.Image"), System.Drawing.Image)
        Me.quayLai_btn.Location = New System.Drawing.Point(11, 23)
        Me.quayLai_btn.Name = "quayLai_btn"
        Me.quayLai_btn.Size = New System.Drawing.Size(42, 43)
        Me.quayLai_btn.TabIndex = 69
        Me.quayLai_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.quayLai_btn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(425, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 29)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "THỜI KHÓA BIỂU SINH VIÊN"
        '
        'TKB_dgv
        '
        Me.TKB_dgv.AllowUserToAddRows = False
        Me.TKB_dgv.AllowUserToDeleteRows = False
        Me.TKB_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TKB_dgv.Location = New System.Drawing.Point(12, 164)
        Me.TKB_dgv.Name = "TKB_dgv"
        Me.TKB_dgv.ReadOnly = True
        Me.TKB_dgv.RowHeadersWidth = 51
        Me.TKB_dgv.RowTemplate.Height = 24
        Me.TKB_dgv.Size = New System.Drawing.Size(1116, 314)
        Me.TKB_dgv.TabIndex = 73
        '
        'msv_label
        '
        Me.msv_label.AutoSize = True
        Me.msv_label.Location = New System.Drawing.Point(193, 124)
        Me.msv_label.Name = "msv_label"
        Me.msv_label.Size = New System.Drawing.Size(52, 17)
        Me.msv_label.TabIndex = 74
        Me.msv_label.Text = "        .  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Tên sinh viên: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(637, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Số lượng môn học: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Mã sinh viên: "
        '
        'tenSV_label
        '
        Me.tenSV_label.AutoSize = True
        Me.tenSV_label.Location = New System.Drawing.Point(481, 124)
        Me.tenSV_label.Name = "tenSV_label"
        Me.tenSV_label.Size = New System.Drawing.Size(84, 17)
        Me.tenSV_label.TabIndex = 78
        Me.tenSV_label.Text = "                  ."
        '
        'sl_label
        '
        Me.sl_label.AutoSize = True
        Me.sl_label.Location = New System.Drawing.Point(804, 124)
        Me.sl_label.Name = "sl_label"
        Me.sl_label.Size = New System.Drawing.Size(16, 17)
        Me.sl_label.TabIndex = 79
        Me.sl_label.Text = "0"
        '
        'Tc_label
        '
        Me.Tc_label.AutoSize = True
        Me.Tc_label.Location = New System.Drawing.Point(1021, 124)
        Me.Tc_label.Name = "Tc_label"
        Me.Tc_label.Size = New System.Drawing.Size(16, 17)
        Me.Tc_label.TabIndex = 81
        Me.Tc_label.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(911, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 23)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Số tín chỉ: "
        '
        'dkHP_btn
        '
        Me.dkHP_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.dkHP_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dkHP_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dkHP_btn.Image = CType(resources.GetObject("dkHP_btn.Image"), System.Drawing.Image)
        Me.dkHP_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dkHP_btn.Location = New System.Drawing.Point(196, 509)
        Me.dkHP_btn.Name = "dkHP_btn"
        Me.dkHP_btn.Size = New System.Drawing.Size(206, 59)
        Me.dkHP_btn.TabIndex = 82
        Me.dkHP_btn.Text = "Đăng ký học phần"
        Me.dkHP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dkHP_btn.UseVisualStyleBackColor = False
        '
        'huyHP_btn
        '
        Me.huyHP_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.huyHP_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.huyHP_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.huyHP_btn.Image = CType(resources.GetObject("huyHP_btn.Image"), System.Drawing.Image)
        Me.huyHP_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.huyHP_btn.Location = New System.Drawing.Point(653, 509)
        Me.huyHP_btn.Name = "huyHP_btn"
        Me.huyHP_btn.Size = New System.Drawing.Size(179, 59)
        Me.huyHP_btn.TabIndex = 83
        Me.huyHP_btn.Text = "Hủy học phần"
        Me.huyHP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.huyHP_btn.UseVisualStyleBackColor = False
        '
        'ThoiKhoaBieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 633)
        Me.Controls.Add(Me.huyHP_btn)
        Me.Controls.Add(Me.dkHP_btn)
        Me.Controls.Add(Me.Tc_label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sl_label)
        Me.Controls.Add(Me.tenSV_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.msv_label)
        Me.Controls.Add(Me.TKB_dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ThoiKhoaBieu"
        Me.Text = "ThoiKhoaBieu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TKB_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents quayLai_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TKB_dgv As DataGridView
    Friend WithEvents msv_label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tenSV_label As Label
    Friend WithEvents sl_label As Label
    Friend WithEvents Tc_label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dkHP_btn As Button
    Friend WithEvents huyHP_btn As Button
End Class
