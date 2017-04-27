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
                panMenu.Width = 50;
            }
            else
            {
                panMenu.Width = 200;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            this.Dispose();
            

        }
    }
}
