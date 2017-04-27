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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //string userName = "admin";
        //string password = "POS";
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (txtUserName.Text == userName && txtPassword.Text == password)
        //    {                
        //        DashboardForm d = new DashboardForm();
        //        d.Show();
        //        this.Hide();
        //    }
        //    else
        //        lblIncorrect.Text = "Incorrect User Name or Password";

            
        //}
    }
}
