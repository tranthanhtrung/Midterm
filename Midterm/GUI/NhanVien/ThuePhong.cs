﻿using System;
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
    public partial class ThuePhong : Form
    {
        public ThuePhong()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
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
