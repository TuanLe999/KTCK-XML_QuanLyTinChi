using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{
    public partial class ThoiKhoaBieu
    {
        private DataBaseAccess _dbAccess = new DataBaseAccess();

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
            string sqlQuery = string.Format(@"SELECT  MaHP, TenHP,GiaoVien,SoTC,Thu,TietBatDau,TietKetThuc  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" + msv_label.Text + "' ) ORDER BY Thu ");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            TKB_dgv.DataSource = dTable;
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
            sl_label.Text = _dbAccess.GetScalar(sql2).ToString();


            string sql3 = @"SELECT SUM(SoTC)  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" + msv_label.Text + "' )";
            Tc_label.Text = _dbAccess.GetScalar(sql3).ToString();
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
            string sql = " DELETE FROM dbo.ThoiKhoaBieu WHERE ( MSV='" + msv_label.Text + "' AND MaHP='" + MaHP + "')";
            if (_dbAccess.ExecuteNoneQuery(sql))
            {
                MessageBox.Show("Hủy học phần thành công!");
                loadDataOnGridView();
            }
            else
            {
                MessageBox.Show("Hủy học phần thất bại!");
            }

        }
    }
}