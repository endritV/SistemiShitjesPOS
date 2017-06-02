using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;


namespace SistemiShitjesPOS.UI
{
    public partial class UpdateSuppliers : MetroFramework.Forms.MetroForm
    {
        public UpdateSuppliers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                blSupplier.UpdateSupplier(new Suppliers(rdbAktiv.Checked, txtIdSuppliers.Text, txtEmri.Text, txtEmriFurnitorit.Text, txtMbiemri.Text, txtNrFix.Text, txtAdresa.Text, txtNrTelefonit.Text, txtNrBiznesit.Text, txtWeb.Text, txtEmail.Text, txtpershkrimi.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plote your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blSupplier.DeleteSupplier(txtIdSuppliers.Text);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plote your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
