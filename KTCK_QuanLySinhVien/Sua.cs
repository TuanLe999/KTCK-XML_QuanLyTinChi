using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace KTCK_QuanLySinhVien
{
    public partial class Sua
    {
        private DataBaseAccess _dbAccess = new DataBaseAccess();

        public Sua()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Luu_btn_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Bạn có muốn lưu không?", (MsgBoxStyle)((int)MsgBoxStyle.Question + (int)MsgBoxStyle.YesNo), "Sửa") == MsgBoxResult.Yes)
            {
                sua();
                Interaction.MsgBox("Lưu thành công! ");
                Close();

                TrangChu trangChu = new TrangChu();
                trangChu.loadData();
                trangChu.ShowDialog();

            }
        }
        private bool sua()
        {
            string sqlQuery = "update SinhVien set Ten = N'" + name_TextBox.Text + "',Lop = '" + class_cbb.Text + "',GioiTinh=N'" + GenderComboBox.Text + "',SDT='" + phone_TextBox.Text + @"'
                    ,Email=N'" + email_TextBox.Text + "' where MSV = '" + msv_txt.Text + "'";
            return _dbAccess.ExecuteNoneQuery(sqlQuery);
        }

        private void class_cbb_MouseClick(object sender, MouseEventArgs e)
        {
            loadDataOnCombobox();
        }
        private void loadDataOnCombobox()
        {
            string sql = "Select * from dbo.Lop";
            var dTable = _dbAccess.GetDataTable(sql);
            class_cbb.DataSource = dTable;
            class_cbb.ValueMember = "TenLop";
            class_cbb.DisplayMember = "TenLop";
        }
    }
}