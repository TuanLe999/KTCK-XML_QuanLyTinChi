using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KTCK_QuanLySinhVien
{
    public partial class TrangChu
    {


        private DataBaseAccess _dbAccess = new DataBaseAccess();
        private bool _isLoading = false;
        

        public TrangChu()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            loadDataOnGridView();
            loadDataOnCombobox();
        }

        public void loadDataOnCombobox()
        {
            string sql = "Select * from dbo.Lop";
            var dTable = _dbAccess.GetDataTable(sql);
            Class_cbb.DataSource = dTable;
            Class_cbb.ValueMember = "TenLop";
            Class_cbb.DisplayMember = "TenLop";
        }

        private void loadDataOnGridView(string tenLop)
        {
            string sqlQuery = string.Format("Select * from SinhVien where Lop = '" + tenLop + "'");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            dgvStudents.DataSource = dTable;
            {
                var withBlock = dgvStudents;
                withBlock.Columns[0].HeaderText = "Mã sinh viên";
                withBlock.Columns[1].HeaderText = "Tên";
                withBlock.Columns[1].Width = 200;
                withBlock.Columns[2].HeaderText = "Lớp";
                withBlock.Columns[3].HeaderText = "Giới tính";
                withBlock.Columns[4].HeaderText = "Số điện thoại";
                withBlock.Columns[5].HeaderText = "Email";
                withBlock.Columns[5].Width = 200;
            }
        }
        public void loadDataOnGridView()
        {
            string sqlQuery = string.Format("Select * from SinhVien ");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            dgvStudents.DataSource = dTable;
            {
                var withBlock = dgvStudents;
                withBlock.Columns[0].HeaderText = "Mã sinh viên";
                withBlock.Columns[1].HeaderText = "Tên";
                withBlock.Columns[1].Width = 200;
                withBlock.Columns[2].HeaderText = "Lớp";
                withBlock.Columns[3].HeaderText = "Giới tính";
                withBlock.Columns[4].HeaderText = "Số điện thoại";
                withBlock.Columns[5].HeaderText = "Email";
                withBlock.Columns[5].Width = 200;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            _dbAccess.CreateXmlFile("SinhVien");
            loadDataOnCombobox();
            loadDataOnGridView();
            Class_cbb.Text = "";
            txt_timKiem.Enabled = false;
            _isLoading = false;
        }



        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if ((int)Interaction.MsgBox("Bạn có muốn xóa không !", Constants.vbYesNo, "Xác nhận") == 6)
            {
                Xoa();

            }
        }
        private void Xoa()
        {

            // Khai bao bien lay StudentID ma dong can xoa da duoc chon tren gridview
            string MSV = Conversions.ToString(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["MSV"].Value);
            // Khai bao cau lenh Query de xoa
            string sqlQuery = string.Format("DELETE from SinhVien WHERE MSV='{0}'", MSV);
            // Thuc hien xoa
            if (_dbAccess.ExecuteNoneQuery(sqlQuery)) // Xoa thanh cong thi thong bao
            {
                MessageBox.Show("Xóa thành công!");
                // Load lai du lieu tren Gridview
                loadDataOnGridView();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Them.ShowDialog();


        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var editForm = new Sua();
            editForm.msv_txt.Text = Conversions.ToString(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["MSV"].Value);
            {
                var withBlock = dgvStudents;
                editForm.name_TextBox.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["MSV"].Value);
                editForm.name_TextBox.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["Ten"].Value);
                editForm.class_cbb.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["Lop"].Value);
                editForm.GenderComboBox.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["GioiTinh"].Value);
                editForm.phone_TextBox.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["SDT"].Value);
                editForm.email_TextBox.Text = Conversions.ToString(withBlock.Rows[withBlock.CurrentCell.RowIndex].Cells["Email"].Value);
            }
            editForm.ShowDialog();
        }



        private void Class_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isLoading)
            {
                if (string.IsNullOrEmpty(txt_timKiem.Text))
                {
                    loadDataOnGridView(Conversions.ToString(Class_cbb.SelectedValue));
                }
                else
                {
                    timKiem(cbb_timKiem.Text, txt_timKiem.Text, Class_cbb.Text);
                }

            }
        }

        private void lamMoi_btn_Click(object sender, EventArgs e)
        {
            _isLoading = true;
            loadDataOnCombobox();
            loadDataOnGridView();
            Class_cbb.Text = "";
            txt_timKiem.Text = "";
            cbb_timKiem.Text = "";
            txt_timKiem.Enabled = false;
            _isLoading = false;
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Class_cbb.Text))
            {
                timKiem(cbb_timKiem.Text, txt_timKiem.Text);
            }
            else
            {
                timKiem(cbb_timKiem.Text, txt_timKiem.Text, Class_cbb.Text);
            }
        }

        private void timKiem(string column, string value)
        {
            string sqlQuery = string.Format("Select * from SinhVien where " + column + " like N'%" + value + "%'");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            dgvStudents.DataSource = dTable;
            {
                var withBlock = dgvStudents;
                withBlock.Columns[0].HeaderText = "Mã sinh viên";
                withBlock.Columns[1].HeaderText = "Tên";
                withBlock.Columns[1].Width = 200;
                withBlock.Columns[2].HeaderText = "Lớp";
                withBlock.Columns[3].HeaderText = "Giới tính";
                withBlock.Columns[4].HeaderText = "Số điện thoại";
                withBlock.Columns[5].HeaderText = "Email";
                withBlock.Columns[5].Width = 200;
            }
        }

        private void timKiem(string column, string value, string lop)
        {
            string sqlQuery = string.Format("Select * from SinhVien where " + column + " like N'%" + value + "%' and Lop = '" + lop + "'");
            var dTable = _dbAccess.GetDataTable(sqlQuery);
            dgvStudents.DataSource = dTable;
            {
                var withBlock = dgvStudents;
                withBlock.Columns[0].HeaderText = "Mã sinh viên";
                withBlock.Columns[1].HeaderText = "Tên";
                withBlock.Columns[1].Width = 200;
                withBlock.Columns[2].HeaderText = "Lớp";
                withBlock.Columns[3].HeaderText = "Giới tính";
                withBlock.Columns[4].HeaderText = "Số điện thoại";
                withBlock.Columns[5].HeaderText = "Email";
                withBlock.Columns[5].Width = 200;
            }
        }

        private void cbb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_timKiem.Enabled = true;
        }

        private void tkb_btn_Click(object sender, EventArgs e)
        {
            var tkbForm = new ThoiKhoaBieu();
            tkbForm.msv_label.Text = Conversions.ToString(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["MSV"].Value);
            tkbForm.tenSV_label.Text = Conversions.ToString(dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["Ten"].Value);
            tkbForm.ShowDialog();
        }


    }
}