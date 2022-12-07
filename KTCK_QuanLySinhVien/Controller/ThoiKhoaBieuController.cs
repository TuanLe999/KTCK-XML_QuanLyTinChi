using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCK_QuanLySinhVien.Controller
{
    class ThoiKhoaBieuController
    {
        XmlController xmlController = new XmlController();

        public void DkHocPhan(string MSV, string MaHp)
        {
            string noiDung = "<_x0027_ThoiKhoaBieu_x0027_>" +
                    "<MSV>" + MSV+ "</MSV >" +
                    "<MaHP>" + MaHp + "</MaHP>" +
                    "</_x0027_ThoiKhoaBieu_x0027_>";

            xmlController.Them("ThoiKhoaBieu.xml", noiDung);

        }
    }
}
