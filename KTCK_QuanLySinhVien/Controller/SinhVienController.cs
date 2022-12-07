using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCK_QuanLySinhVien.Controller
{
    class SinhVienController
    {
        XmlController xmlController = new XmlController();
        public void ThemSV(string MSV, string Ten, string Lop, string GioiTinh, string SDT, string Email)
        {
            string noiDung = "< _x0027_SinhVien_x0027_ >" +
                    "< MSV >" + 2050531200311 + " </ MSV >" +
                    "<Ten>" + Ten + "</Ten>" +
                    "<Lop>" + Lop + "</Lop>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    " </ _x0027_SinhVien_x0027_ >";
            xmlController.Them("SinhVien.xml", noiDung);

        }

        public void SuaSV(string MSV, string Ten, string Lop, string GioiTinh, string SDT, string Email)
        {

            string noiDung =
                    "< MSV >" + 2050531200311 + " </ MSV >" +
                    "<Ten>" + Ten + "</Ten>" +
                    "<Lop>" + Lop + "</Lop>" +
                    "<GioiTinh>" + GioiTinh + "</GioiTinh>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>";

            xmlController.Sua("SinhVien.xml", "< _x0027_SinhVien_x0027_ >", "MSV", MSV, noiDung);
        }
    }
}


