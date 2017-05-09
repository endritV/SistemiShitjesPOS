using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Data.SqlClient;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewItems : UserControl
    {
        public UC_NewItems()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnBackToUC_Items_Click(object sender, EventArgs e)
        {
            
  
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            blItems.InsertNewItems(new Artikulli(txtEmri.Text, int.Parse(txtBarkodi.Text), txtPershkrimi.Text, cmbCategory.Text));
        }

        private void UC_NewItems_Load(object sender, EventArgs e)
        {

        }
    }
}
