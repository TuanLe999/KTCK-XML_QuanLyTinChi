using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KTCK_QuanLySinhVien
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LopHocPhan : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LopHocPhan));
            this.HP_dgv = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.quayLai_btn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.dangKy_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HP_dgv)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HP_dgv
            // 
            this.HP_dgv.AllowUserToAddRows = false;
            this.HP_dgv.AllowUserToDeleteRows = false;
            this.HP_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HP_dgv.Location = new System.Drawing.Point(16, 98);
            this.HP_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HP_dgv.Name = "HP_dgv";
            this.HP_dgv.ReadOnly = true;
            this.HP_dgv.RowHeadersWidth = 51;
            this.HP_dgv.RowTemplate.Height = 24;
            this.HP_dgv.Size = new System.Drawing.Size(818, 255);
            this.HP_dgv.TabIndex = 74;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel1.Controls.Add(this.quayLai_btn);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(850, 82);
            this.Panel1.TabIndex = 75;
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
            this.Label7.Location = new System.Drawing.Point(290, 30);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(324, 23);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "DANH SÁCH HỌC PHẦN CHƯA ĐĂNG KÝ";
            // 
            // dangKy_btn
            // 
            this.dangKy_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dangKy_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangKy_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dangKy_btn.Image = ((System.Drawing.Image)(resources.GetObject("dangKy_btn.Image")));
            this.dangKy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangKy_btn.Location = new System.Drawing.Point(380, 383);
            this.dangKy_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dangKy_btn.Name = "dangKy_btn";
            this.dangKy_btn.Size = new System.Drawing.Size(107, 48);
            this.dangKy_btn.TabIndex = 76;
            this.dangKy_btn.Text = "ĐĂNG KÝ";
            this.dangKy_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangKy_btn.UseVisualStyleBackColor = false;
            this.dangKy_btn.Click += new System.EventHandler(this.dangKy_btn_Click);
            // 
            // LopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 459);
            this.Controls.Add(this.dangKy_btn);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.HP_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LopHocPhan";
            this.Load += new System.EventHandler(this.LopHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HP_dgv)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal DataGridView HP_dgv;
        internal Panel Panel1;
        internal Button quayLai_btn;
        internal Label Label7;
        internal Button dangKy_btn;
    }
}