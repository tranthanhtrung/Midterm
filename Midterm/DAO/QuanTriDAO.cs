using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.DAO
{
    class QuanTriDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachNhanVien()
        {
            return xlDuLieu.LayDuLieu("Select cmnd, ten, sdt, diaChi, gioiTinh, capBac from QuanTri");
        }
    }
}
