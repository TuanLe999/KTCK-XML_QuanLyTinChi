<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LopHocPhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LopHocPhan))
        Me.HP_dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.quayLai_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dangKy_btn = New System.Windows.Forms.Button()
        CType(Me.HP_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HP_dgv
        '
        Me.HP_dgv.AllowUserToAddRows = False
        Me.HP_dgv.AllowUserToDeleteRows = False
        Me.HP_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HP_dgv.Location = New System.Drawing.Point(21, 121)
        Me.HP_dgv.Name = "HP_dgv"
        Me.HP_dgv.ReadOnly = True
        Me.HP_dgv.RowHeadersWidth = 51
        Me.HP_dgv.RowTemplate.Height = 24
        Me.HP_dgv.Size = New System.Drawing.Size(1091, 314)
        Me.HP_dgv.TabIndex = 74
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.quayLai_btn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 101)
        Me.Panel1.TabIndex = 75
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
        Me.Label7.Location = New System.Drawing.Point(387, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(405, 29)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "DANH SÁCH HỌC PHẦN CHƯA ĐĂNG KÝ"
        '
        'dangKy_btn
        '
        Me.dangKy_btn.BackColor = System.Drawing.SystemColors.Highlight
        Me.dangKy_btn.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangKy_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dangKy_btn.Image = CType(resources.GetObject("dangKy_btn.Image"), System.Drawing.Image)
        Me.dangKy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dangKy_btn.Location = New System.Drawing.Point(506, 471)
        Me.dangKy_btn.Name = "dangKy_btn"
        Me.dangKy_btn.Size = New System.Drawing.Size(143, 59)
        Me.dangKy_btn.TabIndex = 76
        Me.dangKy_btn.Text = "ĐĂNG KÝ"
        Me.dangKy_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dangKy_btn.UseVisualStyleBackColor = False
        '
        'LopHocPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 565)
        Me.Controls.Add(Me.dangKy_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HP_dgv)
        Me.Name = "LopHocPhan"
        Me.Text = "LopHocPhan"
        CType(Me.HP_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HP_dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents quayLai_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dangKy_btn As Button
End Class
