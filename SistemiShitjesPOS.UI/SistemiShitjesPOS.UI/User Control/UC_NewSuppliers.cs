using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewSuppliers : UserControl
    {
        public UC_NewSuppliers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            blSupplier.InsertNewSupplier(new Klienti(rdbAktiv.Checked, txtIdSuppliers.Text, txtEmri.Text, txtEmriFurnitorit.Text, txtMbiemri.Text, txtNrFix.Text, txtAdresa.Text, txtNrTelefonit.Text, txtNrBiznesit.Text, txtWeb.Text, txtEmail.Text, txtpershkrimi.Text));
            
        }

        private void UC_NewSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void txtIdSuppliers_MouseDown(object sender, MouseEventArgs e)
        {
            txtIdSuppliers.Clear();
        }

        private void txtEmri_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmri.Clear();
        }

        private void txtEmriFurnitorit_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmriFurnitorit.Clear();
        }

        private void txtMbiemri_MouseDown(object sender, MouseEventArgs e)
        {
            txtMbiemri.Clear();
        }

        private void txtNrTelefonit_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrTelefonit.Clear();
        }

        private void txtNrFix_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrFix.Clear();
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtNrBiznesit_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrBiznesit.Clear();
        }

        

       

        private void txtAdresa_MouseDown(object sender, MouseEventArgs e)
        {
            txtAdresa.Clear();
        }

        private void txtWeb_MouseDown(object sender, MouseEventArgs e)
        {
            txtWeb.Clear();
        }

        private void txtpershkrimi_MouseDown(object sender, MouseEventArgs e)
        {
            txtpershkrimi.Clear();
        }
    }
}
