using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using KTCK_QuanLySinhVien.Controller;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{
    public partial class ThoiKhoaBieu
    {
        private DataBaseAccess _dbAccess = new DataBaseAccess();
        XmlController xmlConTroller = new XmlController();

        public ThoiKhoaBieu()
        {
            InitializeComponent();
        }
        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            loadDataOnGridView();
        }

        private void loadDataOnGridView()
        {

            if (!File.Exists(Application.StartupPath + "\\ThoiKhoaBieu.xml"))
            {
                xmlConTroller.TaoXML("ThoiKhoaBieu");
            }
            if (!File.Exists(Application.StartupPath + "\\LopHP.xml"))
            {
                xmlConTroller.TaoXML("LopHP");
            }

            var dtTkb = xmlConTroller.HienThi("ThoiKhoaBieu.xml");
            var dtLhp = xmlConTroller.HienThi("LopHP.xml");

            DataTable tb = dtLhp.Clone();
            List<String> hp = new List<string>();
            foreach (DataRow row in dtTkb.Rows)
            {
                var value = row["MSV"].ToString();
                if (row["MSV"].ToString().Equals(msv_label.Text.ToString()))
                {
                    hp.Add(row.Field<String>("MaHP"));
                }
            }

            foreach (DataRow row in dtLhp.Rows)
            {
                if (hp.Contains(row.Field<String>("MaHp")))
                {
                    tb.ImportRow(row);
                }
            }


            TKB_dgv.DataSource = tb;
            {
                var withBlock = TKB_dgv;
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
            string sql2 = @"SELECT COUNT(DISTINCT MaHP)  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" + msv_label.Text + "' )";


            sl_label.Text = tb.Rows.Count.ToString();


            int tc = 0;
            foreach (DataRow row in tb.Rows)
            {
                tc += row.Field<Int32>("SoTC");

            }
            Tc_label.Text = tc.ToString();
        }

        private void dkHP_btn_Click(object sender, EventArgs e)
        {
            var hpForm = new LopHocPhan();
            hpForm.msv = msv_label.Text;
            hpForm.ten = tenSV_label.Text;
            hpForm.loadDataOnGridView();
            Dispose();
            hpForm.ShowDialog();

        }

        private void quayLai_btn_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void huyHP_btn_Click(object sender, EventArgs e)
        {
            if (checkSoLuong() == false)
            {
                Interaction.MsgBox("Chưa đăng ký học phần nào !");
            }
            else if ((int)Interaction.MsgBox("Bạn có muốn hủy học phần này không !", Constants.vbYesNo, "Xác nhận") == 6)
            {
                huyHP();
            }
        }

        private bool checkSoLuong()
        {
            string sql = "SELECT count(MaHP) FROM dbo.LopHP WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" + msv_label.Text + "')";
            int a = Conversions.ToInteger(_dbAccess.GetScalar(sql));
            if (a == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void huyHP()
        {
            string MaHP = Conversions.ToString(TKB_dgv.Rows[TKB_dgv.CurrentCell.RowIndex].Cells["MaHP"].Value);
            xmlConTroller.Xoa("ThoiKhoaBieu.xml", "_x0027_ThoiKhoaBieu_x0027_", "MSV", msv_label.Text, "MaHP", MaHP);

            MessageBox.Show("Hủy học phần thành công!");
            loadDataOnGridView();



        }
    }
}