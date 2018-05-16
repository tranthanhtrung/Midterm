using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidTerm.DTO;
using MidTerm.BUS;

namespace MidTerm
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            var user = bunifuMetroTextbox1.Text;
            var pas = bunifuMetroTextbox2.Text;
            QuanTriBUS tmp = new QuanTriBUS();
            int check = tmp.CheckSignIn(user, pas);
            if( check == 1)
            {
                this.Hide();
                Home Menu = new Home();
                Menu.Show();
            } else if (check == 2)
            {
                this.Hide();
                Dashboard Menu = new Dashboard();
                Menu.Show();
            }
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
