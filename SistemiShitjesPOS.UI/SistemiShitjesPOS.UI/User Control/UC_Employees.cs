using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnNewEmployees_Click(object sender, EventArgs e)
        {
            UC_NewEmployees newEmloyees = new UC_NewEmployees();
            panEmployees.Controls.Clear();
            panEmployees.Controls.Add(newEmloyees);
        }
    }
}
