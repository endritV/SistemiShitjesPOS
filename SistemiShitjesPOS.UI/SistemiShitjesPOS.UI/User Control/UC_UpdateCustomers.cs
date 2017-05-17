using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_UpdateCustomers : UserControl
    {
        public UC_UpdateCustomers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                blKlienti.UpdateKlient(new Klienti(txtCustomersId.Text.ToString(), txtEmri.Text.ToString(), txtAdresa.Text.ToString(), txtNrTel.Text.ToString(), rdbKlient.Checked));
            }
            catch (Exception)
            {

                MessageBox.Show("Inserto te gjitha te dhenat");
            }
            

      
        }

        private void txtIdEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            txtCustomersId.Clear();
        }

        private void txtEmri_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmri.Clear();
        }

        private void txtAdresa_MouseDown(object sender, MouseEventArgs e)
        {
            txtAdresa.Clear();
        }

        private void txtNrTel_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrTel.Clear();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blKlienti.Delete(txtCustomersId.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Inserto Id-n e Klientit");
            }
            
        }

        private void txtEmri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
