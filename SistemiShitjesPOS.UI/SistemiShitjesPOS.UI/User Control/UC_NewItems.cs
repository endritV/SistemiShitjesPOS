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
            try
            {
                blItems.InsertNewItems(new Artikulli(txtEmri.Text, int.Parse(txtBarkodi.Text), txtPershkrimi.Text, cmbCategory.Text));
            }
            catch(Exception)
            {

                MessageBox.Show("Inserto te gjitha te dhenat");
            }
           
        }

        private void UC_NewItems_Load(object sender, EventArgs e)
        {

        }

        private void txtPershkrimi_TextChanged(object sender, EventArgs e)
        {
            txtPershkrimi.Clear();
        }

        private void txtIdItems_MouseDown(object sender, MouseEventArgs e)
        {
            txtIdItems.Clear();
        }

        private void txtBarkodi_MouseDown(object sender, MouseEventArgs e)
        {
            txtBarkodi.Clear();
        }

        private void txtPershkrimi_MouseDown(object sender, MouseEventArgs e)
        {
            txtPershkrimi.Clear();
        }
    }
}
