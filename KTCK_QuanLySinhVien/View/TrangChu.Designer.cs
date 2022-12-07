using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KTCK_QuanLySinhVien
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TrangChu : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Class_cbb = new System.Windows.Forms.ComboBox();
            this.them_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbb_timKiem = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.lamMoi_btn = new System.Windows.Forms.Button();
            this.tkb_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.upLoad_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dowload_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(30, 198);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(854, 321);
            this.dgvStudents.TabIndex = 39;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1103, 105);
            this.Panel1.TabIndex = 41;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.Control;
            this.Label9.Location = new System.Drawing.Point(420, 34);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(368, 33);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.Control;
            this.Label8.Location = new System.Drawing.Point(140, 75);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(159, 19);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "KHOA CÔNG NGHỆ SỐ";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.Control;
            this.Label7.Location = new System.Drawing.Point(140, 47);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(207, 19);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(140, 18);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ĐẠI HỌC ĐÀ NẴNG";
            // 
            // Panel2
            // 
            this.Panel2.BackgroundImage = global::KTCK_QuanLySinhVien.My.Resources.Resources.logo_trường;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Location = new System.Drawing.Point(30, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(94, 104);
            this.Panel2.TabIndex = 0;
            // 
            // Class_cbb
            // 
            this.Class_cbb.FormattingEnabled = true;
            this.Class_cbb.Location = new System.Drawing.Point(758, 155);
            this.Class_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.Class_cbb.Name = "Class_cbb";
            this.Class_cbb.Size = new System.Drawing.Size(92, 21);
            this.Class_cbb.TabIndex = 42;
            this.Class_cbb.SelectedIndexChanged += new System.EventHandler(this.Class_cbb_SelectedIndexChanged);
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.them_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.them_btn.Image = ((System.Drawing.Image)(resources.GetObject("them_btn.Image")));
            this.them_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_btn.Location = new System.Drawing.Point(136, 547);
            this.them_btn.Margin = new System.Windows.Forms.Padding(2);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(107, 48);
            this.them_btn.TabIndex = 34;
            this.them_btn.Text = "Thêm mới";
            this.them_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Delete_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.Image")));
            this.Delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_btn.Location = new System.Drawing.Point(480, 547);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(85, 48);
            this.Delete_btn.TabIndex = 35;
            this.Delete_btn.Text = "Xóa";
            this.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.update_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_btn.Image")));
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(318, 547);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(87, 48);
            this.update_btn.TabIndex = 38;
            this.update_btn.Text = "Sửa";
            this.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(230, 152);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 20);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "TÌM KIẾM";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(686, 154);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 20);
            this.Label3.TabIndex = 44;
            this.Label3.Text = "LỚP";
            // 
            // cbb_timKiem
            // 
            this.cbb_timKiem.FormattingEnabled = true;
            this.cbb_timKiem.Items.AddRange(new object[] {
            "MSV",
            "Ten",
            "SDT"});
            this.cbb_timKiem.Location = new System.Drawing.Point(334, 153);
            this.cbb_timKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_timKiem.Name = "cbb_timKiem";
            this.cbb_timKiem.Size = new System.Drawing.Size(92, 21);
            this.cbb_timKiem.TabIndex = 45;
            this.cbb_timKiem.SelectedIndexChanged += new System.EventHandler(this.cbb_timKiem_SelectedIndexChanged);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(458, 153);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(143, 20);
            this.txt_timKiem.TabIndex = 46;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // lamMoi_btn
            // 
            this.lamMoi_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.lamMoi_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamMoi_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lamMoi_btn.Image = ((System.Drawing.Image)(resources.GetObject("lamMoi_btn.Image")));
            this.lamMoi_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lamMoi_btn.Location = new System.Drawing.Point(47, 137);
            this.lamMoi_btn.Margin = new System.Windows.Forms.Padding(2);
            this.lamMoi_btn.Name = "lamMoi_btn";
            this.lamMoi_btn.Size = new System.Drawing.Size(92, 48);
            this.lamMoi_btn.TabIndex = 47;
            this.lamMoi_btn.Text = "Làm mới";
            this.lamMoi_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lamMoi_btn.UseVisualStyleBackColor = false;
            this.lamMoi_btn.Click += new System.EventHandler(this.lamMoi_btn_Click);
            // 
            // tkb_btn
            // 
            this.tkb_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkb_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tkb_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkb_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tkb_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tkb_btn.Location = new System.Drawing.Point(633, 420);
            this.tkb_btn.Margin = new System.Windows.Forms.Padding(2);
            this.tkb_btn.Name = "tkb_btn";
            this.tkb_btn.Size = new System.Drawing.Size(142, 48);
            this.tkb_btn.TabIndex = 48;
            this.tkb_btn.Text = "Xem thời khóa biểu";
            this.tkb_btn.UseVisualStyleBackColor = false;
            this.tkb_btn.Click += new System.EventHandler(this.tkb_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.upLoad_btn);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.dowload_btn);
            this.panel3.Controls.Add(this.tkb_btn);
            this.panel3.Location = new System.Drawing.Point(13, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 573);
            this.panel3.TabIndex = 49;
            // 
            // upLoad_btn
            // 
            this.upLoad_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.upLoad_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLoad_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upLoad_btn.Image = global::KTCK_QuanLySinhVien.My.Resources.Resources.ic_cloud_upload_128_28296;
            this.upLoad_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upLoad_btn.Location = new System.Drawing.Point(467, 498);
            this.upLoad_btn.Margin = new System.Windows.Forms.Padding(2);
            this.upLoad_btn.Name = "upLoad_btn";
            this.upLoad_btn.Size = new System.Drawing.Size(222, 48);
            this.upLoad_btn.TabIndex = 50;
            this.upLoad_btn.Text = "Lưu trữ dữ liệu lên Database";
            this.upLoad_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upLoad_btn.UseVisualStyleBackColor = false;
            this.upLoad_btn.Click += new System.EventHandler(this.upLoad_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(387, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 48);
            this.button2.TabIndex = 51;
            this.button2.Text = "Thêm mới";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dowload_btn
            // 
            this.dowload_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.dowload_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dowload_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dowload_btn.Image = global::KTCK_QuanLySinhVien.My.Resources.Resources.macos_big_sur_download_folder_icon_186042__1_;
            this.dowload_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dowload_btn.Location = new System.Drawing.Point(200, 498);
            this.dowload_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dowload_btn.Name = "dowload_btn";
            this.dowload_btn.Size = new System.Drawing.Size(192, 48);
            this.dowload_btn.TabIndex = 50;
            this.dowload_btn.Text = "Tải dữ liệu từ Database";
            this.dowload_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dowload_btn.UseVisualStyleBackColor = false;
            this.dowload_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 734);
            this.Controls.Add(this.lamMoi_btn);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.cbb_timKiem);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Class_cbb);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal dsSinhVien DsSinhVien1;
        internal DataGridView dgvStudents;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Label Label7;
        internal Label Label1;
        internal Label Label8;
        internal Label Label9;
        internal ComboBox Class_cbb;
        internal Button them_btn;
        internal Button Delete_btn;
        internal Button update_btn;
        internal Label Label2;
        internal Label Label3;
        internal ComboBox cbb_timKiem;
        internal TextBox txt_timKiem;
        internal Button lamMoi_btn;
        internal Button tkb_btn;
        private Panel panel3;
        internal Button upLoad_btn;
        internal Button button2;
        internal Button dowload_btn;
    }
}