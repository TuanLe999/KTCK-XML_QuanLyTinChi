using System;
using KTCK_QuanLySinhVien.Controller;
using Microsoft.VisualBasic;

namespace KTCK_QuanLySinhVien
{
    public partial class Them
    {

        private DataBaseAccess _dbAccess = new DataBaseAccess();
        SinhVienController sinhVienController = new SinhVienController();
        public Them()
        {
            InitializeComponent();
        }
        private void them_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_TextBox.Text) | string.IsNullOrEmpty(class_cbb.Text) | string.IsNullOrEmpty(GenderComboBox.Text) | string.IsNullOrEmpty(phone_TextBox.Text) | string.IsNullOrEmpty(email_TextBox.Text))
            {
                Interaction.MsgBox("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                try
                {


                    sinhVienController.ThemSV(msv_txt.Text, name_TextBox.Text, class_cbb.Text, GenderComboBox.Text, phone_TextBox.Text, email_TextBox.Text);

                }

                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.ToString());
                }
                Interaction.MsgBox("Thêm thành công !");
                Close();

            }
        }

        private void Them_Load(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}