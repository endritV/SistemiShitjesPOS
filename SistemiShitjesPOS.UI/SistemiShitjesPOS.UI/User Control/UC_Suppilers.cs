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
    public partial class UC_Suppilers : UserControl
    {
        public UC_Suppilers()
        {
            InitializeComponent();
        }

        private void btnNewSuppliers_Click(object sender, EventArgs e)
        {
            UC_NewSuppliers newSuppliers = new UC_NewSuppliers();
            panSuppliers.Controls.Clear();
            panSuppliers.Controls.Add(newSuppliers);
        }
    }
}
