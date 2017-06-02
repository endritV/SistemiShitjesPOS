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
    public partial class UpdateCustomers : MetroFramework.Forms.MetroForm
    {
        public UpdateCustomers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                blKlienti.UpdateKlient(new Klienti(txtCustomersId.Text.ToString(), txtEmri.Text.ToString(), txtAdresa.Text.ToString(), txtNrTel.Text.ToString(), rdbKlient.Checked));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plot your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blKlienti.Delete(txtCustomersId.Text);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plot your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
