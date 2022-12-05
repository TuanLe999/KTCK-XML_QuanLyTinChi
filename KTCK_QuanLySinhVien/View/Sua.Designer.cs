using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KTCK_QuanLySinhVien
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Sua : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sua));
            this.Label1 = new System.Windows.Forms.Label();
            this.msv_txt = new System.Windows.Forms.TextBox();
            this.class_cbb = new System.Windows.Forms.ComboBox();
            this.Luu_btn = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(137, 114);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 17);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Mã sinh viên";
            // 
            // msv_txt
            // 
            this.msv_txt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msv_txt.Location = new System.Drawing.Point(238, 113);
            this.msv_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msv_txt.Name = "msv_txt";
            this.msv_txt.ReadOnly = true;
            this.msv_txt.Size = new System.Drawing.Size(200, 22);
            this.msv_txt.TabIndex = 67;
            // 
            // class_cbb
            // 
            this.class_cbb.FormattingEnabled = true;
            this.class_cbb.Location = new System.Drawing.Point(238, 192);
            this.class_cbb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_cbb.Name = "class_cbb";
            this.class_cbb.Size = new System.Drawing.Size(76, 21);
            this.class_cbb.TabIndex = 66;
            this.class_cbb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.class_cbb_MouseClick);
            // 
            // Luu_btn
            // 
            this.Luu_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Luu_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luu_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Luu_btn.Image = ((System.Drawing.Image)(resources.GetObject("Luu_btn.Image")));
            this.Luu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Luu_btn.Location = new System.Drawing.Point(287, 357);
            this.Luu_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Luu_btn.Name = "Luu_btn";
            this.Luu_btn.Size = new System.Drawing.Size(71, 48);
            this.Luu_btn.TabIndex = 65;
            this.Luu_btn.Text = "Lưu";
            this.Luu_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Luu_btn.UseVisualStyleBackColor = false;
            this.Luu_btn.Click += new System.EventHandler(this.Luu_btn_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(318, 193);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 17);
            this.Label6.TabIndex = 64;
            this.Label6.Text = "Giới tính";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GenderComboBox.Location = new System.Drawing.Point(376, 189);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(60, 25);
            this.GenderComboBox.TabIndex = 63;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(137, 288);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 17);
            this.Label5.TabIndex = 62;
            this.Label5.Text = "Email";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_TextBox.Location = new System.Drawing.Point(238, 288);
            this.email_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(200, 22);
            this.email_TextBox.TabIndex = 61;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(137, 241);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 17);
            this.Label4.TabIndex = 60;
            this.Label4.Text = "Số điện thoại";
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_TextBox.Location = new System.Drawing.Point(238, 240);
            this.phone_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(200, 22);
            this.phone_TextBox.TabIndex = 59;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(137, 155);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 17);
            this.Label3.TabIndex = 58;
            this.Label3.Text = "Tên";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_TextBox.Location = new System.Drawing.Point(238, 154);
            this.name_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(200, 22);
            this.name_TextBox.TabIndex = 57;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(137, 192);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 17);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Lớp";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(2, 2);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(32, 35);
            this.Button1.TabIndex = 69;
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(165, 14);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(279, 23);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "CHỈNH SỬA THÔNG TIN SINH VIÊN";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(1, 10);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(587, 72);
            this.Panel1.TabIndex = 71;
            // 
            // Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 444);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.msv_txt);
            this.Controls.Add(this.class_cbb);
            this.Controls.Add(this.Luu_btn);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.phone_TextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.Label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sua";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal TextBox msv_txt;
        internal ComboBox class_cbb;
        internal Button Luu_btn;
        internal Label Label6;
        internal ComboBox GenderComboBox;
        internal Label Label5;
        internal TextBox email_TextBox;
        internal Label Label4;
        internal TextBox phone_TextBox;
        internal Label Label3;
        internal TextBox name_TextBox;
        internal Label Label2;
        internal Button Button1;
        internal Label Label7;
        internal Panel Panel1;
    }
}