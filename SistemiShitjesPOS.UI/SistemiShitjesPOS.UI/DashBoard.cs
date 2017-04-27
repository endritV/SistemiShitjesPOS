using System.Reflection.Emit;
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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panMenu.Width == 200)
            {
                panMenu.Width = 40;
            }
            else
            {
                panMenu.Width = 200;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            this.Visible = false;
            l1.Show();

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }
    }
}
