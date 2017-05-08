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
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            UC_NewCustomers newCustomers = new UC_NewCustomers();
            panCustomers.Controls.Clear();
            panCustomers.Controls.Add(newCustomers);
        }
    }
}
