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

            if (panMenu.Width == 200 && panMenu2.Width == 200)
            {
                panMenu.Width = 40;
                panMenu2.Width = 40;     
            }
            else
            {
                panMenu.Width = 200;
                panMenu2.Width = 200;
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
            //if (e.KeyCode == Keys.F)
            //{
            //    FormBorderStyle = FormBorderStyle.None;
            //    WindowState = FormWindowState.Maximized;
            //    TopMost = true;

                
            //}
        }

        private void btnDashboards_Click(object sender, EventArgs e)
        {
            UC_Dashboards dashboardUC = new UC_Dashboards();
            panel1.Controls.Clear();
            panel1.Controls.Add(dashboardUC);


            btnDashboards.BackColor = Color.FromArgb(35, 53, 69);
            btnItems.BackColor = Color.FromArgb(47, 64, 80);
            btnCustomers.BackColor = Color.FromArgb(47, 64, 80);
            btnEmployees.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnReports.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnSuppliers.BackColor = Color.FromArgb(47, 64, 80);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            UC_Items itemsUC = new UC_Items();
            panel1.Controls.Clear();
            panel1.Controls.Add(itemsUC);

            btnItems.BackColor = Color.FromArgb(35, 53, 69);
            btnDashboards.BackColor = Color.FromArgb(47, 64, 80);
            btnCustomers.BackColor = Color.FromArgb(47, 64, 80);
            btnEmployees.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnReports.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnSuppliers.BackColor = Color.FromArgb(47, 64, 80);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            UC_Employees employeesUC = new UC_Employees();
            panel1.Controls.Clear();
            panel1.Controls.Add(employeesUC);


            btnEmployees.BackColor = Color.FromArgb(35, 53, 69);
            btnDashboards.BackColor = Color.FromArgb(47, 64, 80);
            btnCustomers.BackColor = Color.FromArgb(47, 64, 80);
            btnItems.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnReports.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnSuppliers.BackColor = Color.FromArgb(47, 64, 80);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UC_Customers customers = new UC_Customers();
            panel1.Controls.Clear();
            panel1.Controls.Add(customers);

            btnCustomers.BackColor = Color.FromArgb(35, 53, 69);
            btnDashboards.BackColor = Color.FromArgb(47, 64, 80);
            btnEmployees.BackColor = Color.FromArgb(47, 64, 80);
            btnItems.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnReports.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnSuppliers.BackColor = Color.FromArgb(47, 64, 80);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            UC_Suppilers suppliers = new UC_Suppilers();
            panel1.Controls.Clear();
            panel1.Controls.Add(suppliers);


            btnSuppliers.BackColor = Color.FromArgb(35, 53, 69);
            btnDashboards.BackColor = Color.FromArgb(47, 64, 80);
            btnEmployees.BackColor = Color.FromArgb(47, 64, 80);
            btnItems.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnReports.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnCustomers.BackColor = Color.FromArgb(47, 64, 80);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Raports raportsUC = new UC_Raports();
            panel1.Controls.Clear();
            panel1.Controls.Add(raportsUC);


            btnReports.BackColor = Color.FromArgb(35, 53, 69);
            btnDashboards.BackColor = Color.FromArgb(47, 64, 80);
            btnEmployees.BackColor = Color.FromArgb(47, 64, 80);
            btnItems.BackColor = Color.FromArgb(47, 64, 80);
            btnExpenses.BackColor = Color.FromArgb(47, 64, 80);
            btnGiftCard.BackColor = Color.FromArgb(47, 64, 80);
            btnPriceRules.BackColor = Color.FromArgb(47, 64, 80);
            btnSuppliers.BackColor = Color.FromArgb(47, 64, 80);
            btnSales.BackColor = Color.FromArgb(47, 64, 80);
            btnCustomers.BackColor = Color.FromArgb(47, 64, 80);
        }
    }
}
