using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
           

            if (txbUsername.Text == "admin" && txbPassword.Text == "POS")
            {
                DashBoard d1 = new DashBoard();
                this.Visible = false;
                d1.ShowDialog();
                
                

                txbUsername.Clear();
                txbPassword.Clear();
                
            }
            else
            {
                label3.Text = "Username or Password Incorrect";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
