using MidTerm.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.BUS
{
    class QuanTriBUS
    {
        QuanTriDAO quanTriDAO = new QuanTriDAO();

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                return quanTriDAO.LayDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
