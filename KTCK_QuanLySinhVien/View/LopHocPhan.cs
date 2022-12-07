using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using KTCK_QuanLySinhVien.Controller;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{
    public partial class LopHocPhan
    {
        private DataBaseAccess _dbAccess = new DataBaseAccess();
        public string msv;
        public string ten;

        XmlController xmlController = new XmlController();
        ThoiKhoaBieuController tkbController = new ThoiKhoaBieuController();

        public LopHocPhan()
        {
            InitializeComponent();
        }
        private void LopHocPhan_Load(object sender, EventArgs e)
        {
            check();
        }

        public void back()
        {
            var tkb = new ThoiKhoaBieu();
            tkb.msv_label.Text = msv;
            tkb.tenSV_label.Text = ten;
            Dispose();
            tkb.ShowDialog();
        }

        public void loadDataOnGridView()
        {

            var dtTkb = xmlController.HienThi("ThoiKhoaBieu.xml");
            var dtLhp = xmlController.HienThi("LopHP.xml");

            DataTable tb = dtLhp.Clone();
            List<String> hp = new List<string>();
            foreach (DataRow row in dtTkb.Rows)
            {
                var value = row["MSV"].ToString();
                if (row["MSV"].ToString().Equals(msv))
                {
                    hp.Add(row.Field<String>("MaHP"));
                }
            }

            foreach (DataRow row in dtLhp.Rows)
            {
                if (!hp.Contains(row.Field<String>("MaHp")))
                {
                    tb.ImportRow(row);
                }
            }
            HP_dgv.DataSource = tb;
            {
                var withBlock = HP_dgv;
                withBlock.Columns[0].HeaderText = "Mã học phần";
                withBlock.Columns[1].HeaderText = "Tên học phần";
                withBlock.Columns[1].Width = 200;
                withBlock.Columns[2].HeaderText = "Giáo viên";
                withBlock.Columns[2].Width = 150;
                withBlock.Columns[3].HeaderText = "Số tín chỉ";
                withBlock.Columns[4].HeaderText = "Thứ";
                withBlock.Columns[4].Width = 30;
                withBlock.Columns[5].HeaderText = "Tiết bắt đầu";
                withBlock.Columns[6].HeaderText = "Tiết kết thúc";

            }

        }

        private void check()
        {
            var dtTkb = xmlController.HienThi("ThoiKhoaBieu.xml");
            var dtLhp = xmlController.HienThi("LopHP.xml");

            DataTable tb = dtLhp.Clone();
            List<String> hp = new List<string>();
            foreach (DataRow row in dtTkb.Rows)
            {
                var value = row["MSV"].ToString();
                if (row["MSV"].ToString().Equals(msv))
                {
                    hp.Add(row.Field<String>("MaHP"));
                }
            }

            foreach (DataRow row in dtLhp.Rows)
            {
                if (!hp.Contains(row.Field<String>("MaHp")))
                {
                    tb.ImportRow(row);
                }
            }

            int a = tb.Rows.Count;
            if (a == 0)
            {
                Interaction.MsgBox("Không còn học phần nào để đăng ký! ");
                back();
            }
        }

        private void dangKy_btn_Click(object sender, EventArgs e)
        {
            if ((int)Interaction.MsgBox("Bạn có muốn đăng ký học phần này không !", Constants.vbYesNo, "Xác nhận") == 6)
            {
                dangKy();
            }
            back();
        }
        private void dangKy()
        {

            // Khai bao bien lay StudentID ma dong can xoa da duoc chon tren gridview
            string MaHP = Conversions.ToString(HP_dgv.Rows[HP_dgv.CurrentCell.RowIndex].Cells["MaHP"].Value);
            // Khai bao cau lenh Query de xoa
            tkbController.DkHocPhan(msv, MaHP);
            // Thuc hien xoa

            MessageBox.Show("Đăng ký thành công!");

            loadDataOnGridView();

        }

        private void quayLai_btn_Click(object sender, EventArgs e)
        {
            back();
        }
    }
}