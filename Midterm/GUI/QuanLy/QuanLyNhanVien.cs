using MidTerm.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            QuanTriBUS quanTriBUS = new QuanTriBUS();

            bunifuCustomDataGrid1.DataSource = quanTriBUS.LayDanhSachNhanVien();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
