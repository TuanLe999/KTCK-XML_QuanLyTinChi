using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KTCK_QuanLySinhVien
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Them : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Them));
            this.them_btn = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.class_cbb = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.msv_txt = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.them_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.them_btn.Image = ((System.Drawing.Image)(resources.GetObject("them_btn.Image")));
            this.them_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_btn.Location = new System.Drawing.Point(285, 382);
            this.them_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(103, 48);
            this.them_btn.TabIndex = 52;
            this.them_btn.Text = "Thêm mới";
            this.them_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(326, 210);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 17);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Giới tính";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GenderComboBox.Location = new System.Drawing.Point(384, 206);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(60, 25);
            this.GenderComboBox.TabIndex = 50;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(145, 306);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 17);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "Email";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_TextBox.Location = new System.Drawing.Point(246, 305);
            this.email_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(200, 22);
            this.email_TextBox.TabIndex = 48;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(145, 258);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 17);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Số điện thoại";
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_TextBox.Location = new System.Drawing.Point(246, 258);
            this.phone_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(200, 22);
            this.phone_TextBox.TabIndex = 46;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(145, 172);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 17);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Tên";
            // 
            // name_TextBox
            // 
            this.name_TextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_TextBox.Location = new System.Drawing.Point(246, 171);
            this.name_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(200, 22);
            this.name_TextBox.TabIndex = 44;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(145, 209);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 17);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Lớp";
            // 
            // class_cbb
            // 
            this.class_cbb.FormattingEnabled = true;
            this.class_cbb.Location = new System.Drawing.Point(246, 209);
            this.class_cbb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_cbb.Name = "class_cbb";
            this.class_cbb.Size = new System.Drawing.Size(76, 21);
            this.class_cbb.TabIndex = 53;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(145, 131);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 17);
            this.Label1.TabIndex = 55;
            this.Label1.Text = "Mã sinh viên";
            // 
            // msv_txt
            // 
            this.msv_txt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msv_txt.Location = new System.Drawing.Point(246, 130);
            this.msv_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msv_txt.Name = "msv_txt";
            this.msv_txt.Size = new System.Drawing.Size(200, 22);
            this.msv_txt.TabIndex = 54;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(10, 11);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(33, 33);
            this.Button1.TabIndex = 70;
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(2, 2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(597, 75);
            this.Panel1.TabIndex = 72;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(229, 28);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(181, 23);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "THÊM SINH VIÊN MỚI";
            // 
            // Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 449);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.msv_txt);
            this.Controls.Add(this.class_cbb);
            this.Controls.Add(this.them_btn);
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
            this.Name = "Them";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Them";
            this.Load += new System.EventHandler(this.Them_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button them_btn;
        internal Label Label6;
        internal ComboBox GenderComboBox;
        internal Label Label5;
        internal TextBox email_TextBox;
        internal Label Label4;
        internal TextBox phone_TextBox;
        internal Label Label3;
        internal TextBox name_TextBox;
        internal Label Label2;
        internal ComboBox class_cbb;
        internal Label Label1;
        internal TextBox msv_txt;
        internal Button Button1;
        internal Panel Panel1;
        internal Label Label7;
    }
}