using MidTerm.DAO;
using MidTerm.DTO;
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
        public QuanTri LayThongTinMotNhanVien(string user)
        {
            return quanTriDAO.LayThongTinMotNhanVien(user);
        }

        public int CheckSignIn(string user, string pas)
        {
            QuanTri qt = new QuanTri();
            qt = LayThongTinMotNhanVien(user);
            if(qt.password == pas)
            {
                return qt.capBac;
            }
            else return 0;
        }
    }
}
