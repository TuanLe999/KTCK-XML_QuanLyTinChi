using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KTCK_QuanLySinhVien.Controller
{
    class SinhVienController
    {
        XmlController xmlController = new XmlController();
        
        public DataTable TimSvTheoTen(string Ten)
        {
            DataTable dt = new DataTable();
            //XmlTextReader reader = new XmlTextReader("TaiKhoan.xml");
            //XmlDocument doc = new XmlDocument();
            //doc.Load(reader);
            //XmlNodeList sv = doc.SelectNodes("NewDataSet/_x0027_SinhVien_x0027_[Ten='" + Ten + "']");

            //doc.
            //string FilePath = Application.StartupPath + "\\SinhVien.xml";
            //if (File.Exists(FilePath))
            //{
            //    FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
            //    dt.ReadXml(fsReadXML);
            //    fsReadXML.Close();
            //}
            //else
            //{
            //    MessageBox.Show("File XML SinhVien.xml không tồn tại");
            //}

            return dt;
        }
        
        public void ThemSV(string MSV, string Ten, string Lop, string GioiTinh, string SDT, string Email)
        {
            string noiDung = "<_x0027_SinhVien_x0027_>" +
                    "<MSV>" + MSV + " </MSV >" +
                    "<Ten>" + Ten + "</Ten>" +
                    "<Lop>" + Lop + "</Lop>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    " </_x0027_SinhVien_x0027_>";
            xmlController.Them("SinhVien.xml", noiDung);

        }

        public void SuaSV(string MSV, string Ten, string Lop, string GioiTinh, string SDT, string Email)
        {

            string noiDung =
                    "<MSV>" + MSV + " </MSV>" +
                    "<Ten>" + Ten + "</Ten>" +
                    "<Lop>" + Lop + "</Lop>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>";

            xmlController.Sua("SinhVien.xml", "_x0027_SinhVien_x0027_", "MSV", MSV, noiDung);
        }


        public void XoaSV(string MSV)
        {
            xmlController.Xoa("SinhVien.xml", "_x0027_SinhVien_x0027_", "MSV", MSV);
        }
    }
}


