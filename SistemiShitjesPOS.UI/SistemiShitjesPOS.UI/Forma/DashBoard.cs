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
using MetroFramework;

namespace SistemiShitjesPOS.UI
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {
        public DashBoard()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Location.X == 200)
            {
                panel1.Location = new Point(40, 0);

            }
            else
            {
                panel1.Location = new Point(200, 0);
            }

            if (panMenu.Width == 200  )
            {
                panMenu.Width = 40;
                panel1.Width = 900;
                
            }
            else
            {
                panMenu.Width = 200;
                     
            }

            
        }
        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "My Application",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                LoginForm l1 = new LoginForm();
                l1.Visible = true;
                this.Close();
            }
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
            if (e.KeyCode == Keys.F)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
        }
        private void btnDashboards_Click(object sender, EventArgs e)
        {
            UC_Dashboards dashboardUC = new UC_Dashboards();
            panel1.Controls.Clear();
            panel1.Controls.Add(dashboardUC);
           
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            UC_Items itemsUC = new UC_Items();
            panel1.Controls.Clear();
            panel1.Controls.Add(itemsUC);
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            UC_Employees employeesUC = new UC_Employees();
            panel1.Controls.Clear();
            panel1.Controls.Add(employeesUC);
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UC_Customers customers = new UC_Customers();
            panel1.Controls.Clear();
            panel1.Controls.Add(customers);
        }
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            UC_Suppilers suppliers = new UC_Suppilers();
            panel1.Controls.Clear();
            panel1.Controls.Add(suppliers);
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Raports raportsUC = new UC_Raports();
            panel1.Controls.Clear();
            panel1.Controls.Add(raportsUC);  
        }
        private void btnSectoreRole_Click(object sender, EventArgs e)
        {
            UC_SektoriRoli sr = new UC_SektoriRoli();
            panel1.Controls.Clear();
            panel1.Controls.Add(sr);
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        
    }
}
