using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SistemiShitjesPOS.UI
{
    public partial class DashBoard : MetroFramework.Forms.MetroForm
    {

        //public static string Lang { get; set; } = "en";
        //private bool IsOnLoad = false;
        //public static CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
        
        public DashBoard()
        {
            
            //currentCulture = new CultureInfo("sq-AL");
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UC_Dashboards da = new UC_Dashboards();
            panel1.Controls.Clear();
            panel1.Controls.Add(da);
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

            if (panMenu.Width == 200 )
            {
                panMenu.Width = 40;
                
            }
            else
            {
                panMenu.Width = 200;               
            }

          //asdasdasdasdasd
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
       
        private void btnDashboards_Click(object sender, EventArgs e)
        {
            UC_Dashboards da = new UC_Dashboards();
            panel1.Controls.Clear();
            panel1.Controls.Add(da);
          

           
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingForma sf = new SettingForma();
            sf.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\Endrit Vitija\\Desktop\\NewProject.hmxz");
        }
    }
}
