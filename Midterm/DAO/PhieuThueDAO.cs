using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MidTerm.DAO
{
    class PhieuThueDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachPhieuThue()
        {
            return xlDuLieu.LayDuLieu("Select khachHang,maPhong,ngayThue from PhieuThuePhong");
        }
    }
}
