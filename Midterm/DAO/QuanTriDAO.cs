using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidTerm.DTO;

namespace MidTerm.DAO
{
    class QuanTriDAO
    {
        XL_DULIEU xlDuLieu = new XL_DULIEU();
        public DataTable LayDanhSachNhanVien()
        {
            return xlDuLieu.LayDuLieu("Select cmnd, ten, sdt, diaChi, gioiTinh, capBac from QuanTri");
        }
        public QuanTri LayThongTinMotNhanVien(string user)
        {
            string sql = "Select * from QuanTri where username = '" + user + "'" ;
            var tmp = xlDuLieu.LayDuLieu(sql).AsEnumerable().Take(1).ToArray()[0].ItemArray;
            QuanTri result = new QuanTri();
            result.cmnd = tmp[0].ToString();
            result.ten = tmp[1].ToString();
            result.sdt = tmp[2].ToString();
            result.diaChi = tmp[3].ToString();
            result.gioiTinh = tmp[4].ToString();
            result.username = tmp[5].ToString();
            result.password = tmp[6].ToString();
            result.capBac = Convert.ToInt32(tmp[7]);
            return result;
        }
    }
}
