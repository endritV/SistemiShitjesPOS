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
    public partial class NewEmployees : MetroFramework.Forms.MetroForm
    {
        public NewEmployees()
        {
            InitializeComponent();
        }

        private void btnSubmitEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                blEmployees.InsertNewEmployees(new Puntori(txtIdEmployees.Text, int.Parse(cmbSektoriId.Text), txtEmri.Text, txtMbiemri.Text, DateTime.Parse(dtDiteLindja.Text), txtNrTelefonit.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, int.Parse(cmbRoliId.Text), txtAdresa.Text));
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
