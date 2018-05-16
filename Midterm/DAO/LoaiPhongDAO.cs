using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MidTerm.DAO
{
    class LoaiPhongDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachLoaiPhong()
        {
            return xlDuLieu.LayDuLieu("Select tenLoai,donGia from LoaiPhong");
        }
    }
}
