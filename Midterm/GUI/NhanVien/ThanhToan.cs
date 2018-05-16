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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ThuePhong Menu = new ThuePhong();
            Menu.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            DanhMucPhong Menu = new DanhMucPhong();
            Menu.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            ThanhToan Menu = new ThanhToan();
            Menu.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            this.Hide();
            ThongTinDichVu Menu = new ThongTinDichVu();
            Menu.Show();
        }
    }
}
