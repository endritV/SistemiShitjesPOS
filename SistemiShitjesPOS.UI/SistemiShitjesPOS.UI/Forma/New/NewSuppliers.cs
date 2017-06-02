using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class NewSuppliers : MetroFramework.Forms.MetroForm
    {
        public NewSuppliers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                blSupplier.InsertNewSupplier(new Suppliers(rdbAktiv.Checked, txtIdSuppliers.Text, txtEmri.Text, txtEmriFurnitorit.Text, txtMbiemri.Text, txtNrFix.Text, txtAdresa.Text, txtNrTelefonit.Text, txtNrBiznesit.Text, txtWeb.Text, txtEmail.Text, txtpershkrimi.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plot your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MetroFramework.MetroMessageBox.Show(this, "Customers insert with successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
