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
    public partial class UpdateEmployees : MetroFramework.Forms.MetroForm
    {
        public UpdateEmployees()
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

                MetroFramework.MetroMessageBox.Show(this, "Please plote your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blEmployees.DeleteEmployee(txtIdEmployees.Text);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please plote your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
