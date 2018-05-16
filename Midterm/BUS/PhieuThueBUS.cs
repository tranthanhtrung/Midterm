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
    class PhieuThueBUS
    {
        PhieuThueDAO pThueDAO = new PhieuThueDAO();

        public DataTable LayDanhSachPhieuThue()
        {
            try
            {
                return pThueDAO.LayDanhSachPhieuThue();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
