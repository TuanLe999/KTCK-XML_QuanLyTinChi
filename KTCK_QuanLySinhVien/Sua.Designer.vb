<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sua))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msv_txt = New System.Windows.Forms.TextBox()
        Me.class_cbb = New System.Windows.Forms.ComboBox()
        Me.Luu_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.phone_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Mã sinh viên"
        '
        'msv_txt
        '
        Me.msv_txt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msv_txt.Location = New System.Drawing.Point(318, 139)
        Me.msv_txt.Name = "msv_txt"
        Me.msv_txt.ReadOnly = True
        Me.msv_txt.Size = New System.Drawing.Size(265, 26)
        Me.msv_txt.TabIndex = 67
        '
        'class_cbb
        '
        Me.class_cbb.FormattingEnabled = True
        Me.class_cbb.Location = New System.Drawing.Point(318, 236)
        Me.class_cbb.Name = "class_cbb"
        Me.class_cbb.Size = New System.Drawing.Size(100, 24)
        Me.class_cbb.TabIndex = 66
        '
        'Luu_btn
        '
        Me.Luu_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.Luu_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luu_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Luu_btn.Image = CType(resources.GetObject("Luu_btn.Image"), System.Drawing.Image)
        Me.Luu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Luu_btn.Location = New System.Drawing.Point(383, 439)
        Me.Luu_btn.Name = "Luu_btn"
        Me.Luu_btn.Size = New System.Drawing.Size(95, 59)
        Me.Luu_btn.TabIndex = 65
        Me.Luu_btn.Text = "Lưu"
        Me.Luu_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Luu_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Giới tính"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.GenderComboBox.Location = New System.Drawing.Point(502, 233)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(79, 29)
        Me.GenderComboBox.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Email"
        '
        'email_TextBox
        '
        Me.email_TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_TextBox.Location = New System.Drawing.Point(318, 354)
        Me.email_TextBox.Name = "email_TextBox"
        Me.email_TextBox.Size = New System.Drawing.Size(265, 26)
        Me.email_TextBox.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Số điện thoại"
        '
        'phone_TextBox
        '
        Me.phone_TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_TextBox.Location = New System.Drawing.Point(318, 296)
        Me.phone_TextBox.Name = "phone_TextBox"
        Me.phone_TextBox.Size = New System.Drawing.Size(265, 26)
        Me.phone_TextBox.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Tên"
        '
        'name_TextBox
        '
        Me.name_TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_TextBox.Location = New System.Drawing.Point(318, 190)
        Me.name_TextBox.Name = "name_TextBox"
        Me.name_TextBox.Size = New System.Drawing.Size(265, 26)
        Me.name_TextBox.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Lớp"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 43)
        Me.Button1.TabIndex = 69
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(220, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(350, 29)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "CHỈNH SỬA THÔNG TIN SINH VIÊN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(1, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 89)
        Me.Panel1.TabIndex = 71
        '
        'Sua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 547)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msv_txt)
        Me.Controls.Add(Me.class_cbb)
        Me.Controls.Add(Me.Luu_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.email_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phone_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.name_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Sua"
        Me.Text = "Sua"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents msv_txt As TextBox
    Friend WithEvents class_cbb As ComboBox
    Friend WithEvents Luu_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents email_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents phone_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents name_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
