using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{
    public partial class LopHocPhan
    {
        private DataBaseAccess _dbAccess = new DataBaseAccess();
        public string msv;
        public string ten;

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
            string sqlQuery = string.Format("SELECT * FROM dbo.LopHP WHERE MaHP NOT IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" + msv + "') ORDER BY Thu ");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            HP_dgv.DataSource = dTable;
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
            string sql = " SELECT COUNT(DISTINCT MaHP) FROM dbo.LopHP WHERE MaHP NOT IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" + msv + "')";
            int a = Conversions.ToInteger(_dbAccess.GetScalar(sql).ToString());
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
            string sqlQuery = string.Format("Insert into ThoiKhoaBieu values ('" + msv + "','" + MaHP + "') ");
            // Thuc hien xoa
            if (_dbAccess.ExecuteNoneQuery(sqlQuery)) // 
            {
                MessageBox.Show("Đăng ký  thành công!");
                // Load lai du lieu tren Gridview
                loadDataOnGridView();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }

        private void quayLai_btn_Click(object sender, EventArgs e)
        {
            back();
        }
    }
}