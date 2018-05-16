using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MidTerm.DAO;

namespace MidTerm.BUS
{
    class LoaiPhongBUS
    {
        LoaiPhongDAO lPhongDAO = new LoaiPhongDAO();

        public DataTable LayDanhSachLoaiPhong()
        {
            try
            {
                return lPhongDAO.LayDanhSachLoaiPhong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
