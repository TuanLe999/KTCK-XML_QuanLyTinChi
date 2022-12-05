using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KTCK_QuanLySinhVien
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ThoiKhoaBieu : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThoiKhoaBieu));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.quayLai_btn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.TKB_dgv = new System.Windows.Forms.DataGridView();
            this.msv_label = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.tenSV_label = new System.Windows.Forms.Label();
            this.sl_label = new System.Windows.Forms.Label();
            this.Tc_label = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.dkHP_btn = new System.Windows.Forms.Button();
            this.huyHP_btn = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel1.Controls.Add(this.quayLai_btn);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(1, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(845, 82);
            this.Panel1.TabIndex = 72;
            // 
            // quayLai_btn
            // 
            this.quayLai_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.quayLai_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLai_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quayLai_btn.Image = ((System.Drawing.Image)(resources.GetObject("quayLai_btn.Image")));
            this.quayLai_btn.Location = new System.Drawing.Point(8, 19);
            this.quayLai_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quayLai_btn.Name = "quayLai_btn";
            this.quayLai_btn.Size = new System.Drawing.Size(32, 35);
            this.quayLai_btn.TabIndex = 69;
            this.quayLai_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quayLai_btn.UseVisualStyleBackColor = false;
            this.quayLai_btn.Click += new System.EventHandler(this.quayLai_btn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(319, 19);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(226, 23);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "THỜI KHÓA BIỂU SINH VIÊN";
            // 
            // TKB_dgv
            // 
            this.TKB_dgv.AllowUserToAddRows = false;
            this.TKB_dgv.AllowUserToDeleteRows = false;
            this.TKB_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TKB_dgv.Location = new System.Drawing.Point(9, 133);
            this.TKB_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TKB_dgv.Name = "TKB_dgv";
            this.TKB_dgv.ReadOnly = true;
            this.TKB_dgv.RowHeadersWidth = 51;
            this.TKB_dgv.RowTemplate.Height = 24;
            this.TKB_dgv.Size = new System.Drawing.Size(837, 255);
            this.TKB_dgv.TabIndex = 73;
            // 
            // msv_label
            // 
            this.msv_label.AutoSize = true;
            this.msv_label.Location = new System.Drawing.Point(145, 101);
            this.msv_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msv_label.Name = "msv_label";
            this.msv_label.Size = new System.Drawing.Size(40, 13);
            this.msv_label.TabIndex = 74;
            this.msv_label.Text = "        .  ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(266, 98);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 18);
            this.Label2.TabIndex = 75;
            this.Label2.Text = "Tên sinh viên: ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(478, 98);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(128, 18);
            this.Label3.TabIndex = 76;
            this.Label3.Text = "Số lượng môn học: ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(50, 98);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 18);
            this.Label4.TabIndex = 77;
            this.Label4.Text = "Mã sinh viên: ";
            // 
            // tenSV_label
            // 
            this.tenSV_label.AutoSize = true;
            this.tenSV_label.Location = new System.Drawing.Point(361, 101);
            this.tenSV_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenSV_label.Name = "tenSV_label";
            this.tenSV_label.Size = new System.Drawing.Size(64, 13);
            this.tenSV_label.TabIndex = 78;
            this.tenSV_label.Text = "                  .";
            // 
            // sl_label
            // 
            this.sl_label.AutoSize = true;
            this.sl_label.Location = new System.Drawing.Point(603, 101);
            this.sl_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sl_label.Name = "sl_label";
            this.sl_label.Size = new System.Drawing.Size(13, 13);
            this.sl_label.TabIndex = 79;
            this.sl_label.Text = "0";
            // 
            // Tc_label
            // 
            this.Tc_label.AutoSize = true;
            this.Tc_label.Location = new System.Drawing.Point(766, 101);
            this.Tc_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tc_label.Name = "Tc_label";
            this.Tc_label.Size = new System.Drawing.Size(13, 13);
            this.Tc_label.TabIndex = 81;
            this.Tc_label.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(683, 98);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 18);
            this.Label5.TabIndex = 80;
            this.Label5.Text = "Số tín chỉ: ";
            // 
            // dkHP_btn
            // 
            this.dkHP_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dkHP_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkHP_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dkHP_btn.Image = ((System.Drawing.Image)(resources.GetObject("dkHP_btn.Image")));
            this.dkHP_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dkHP_btn.Location = new System.Drawing.Point(147, 414);
            this.dkHP_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dkHP_btn.Name = "dkHP_btn";
            this.dkHP_btn.Size = new System.Drawing.Size(154, 48);
            this.dkHP_btn.TabIndex = 82;
            this.dkHP_btn.Text = "Đăng ký học phần";
            this.dkHP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dkHP_btn.UseVisualStyleBackColor = false;
            this.dkHP_btn.Click += new System.EventHandler(this.dkHP_btn_Click);
            // 
            // huyHP_btn
            // 
            this.huyHP_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.huyHP_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huyHP_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.huyHP_btn.Image = ((System.Drawing.Image)(resources.GetObject("huyHP_btn.Image")));
            this.huyHP_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.huyHP_btn.Location = new System.Drawing.Point(490, 414);
            this.huyHP_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.huyHP_btn.Name = "huyHP_btn";
            this.huyHP_btn.Size = new System.Drawing.Size(134, 48);
            this.huyHP_btn.TabIndex = 83;
            this.huyHP_btn.Text = "Hủy học phần";
            this.huyHP_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.huyHP_btn.UseVisualStyleBackColor = false;
            this.huyHP_btn.Click += new System.EventHandler(this.huyHP_btn_Click);
            // 
            // ThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 514);
            this.Controls.Add(this.huyHP_btn);
            this.Controls.Add(this.dkHP_btn);
            this.Controls.Add(this.Tc_label);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.sl_label);
            this.Controls.Add(this.tenSV_label);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.msv_label);
            this.Controls.Add(this.TKB_dgv);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThoiKhoaBieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThoiKhoaBieu";
            this.Load += new System.EventHandler(this.ThoiKhoaBieu_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal Button quayLai_btn;
        internal Label Label7;
        internal DataGridView TKB_dgv;
        internal Label msv_label;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label tenSV_label;
        internal Label sl_label;
        internal Label Tc_label;
        internal Label Label5;
        internal Button dkHP_btn;
        internal Button huyHP_btn;
    }
}