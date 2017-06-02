using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class NewCustomers : MetroFramework.Forms.MetroForm
    {
        public NewCustomers()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void NewCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                blKlienti.InsertNewClietn(new Klienti(txtIdKlient.Text, txtEmri.Text, txtAdresa.Text, txtNrTelefonit.Text,rdbKlient.Checked));

            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plot your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //finally
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Customers insert with successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }
    }
}
