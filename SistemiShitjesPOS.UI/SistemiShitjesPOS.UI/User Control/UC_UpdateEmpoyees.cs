using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_UpdateEmpoyees : UserControl
    {
        public UC_UpdateEmpoyees()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blEmployees.DeleteEmployee(txtIdEmployees.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Shkruaje Id e Puntorit");
            }
            
        }

        private void btnSubmitEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                blEmployees.InsertNewEmployees(new Puntori(txtIdEmployees.Text, int.Parse(cmbSektoriId.Text), txtEmri.Text, txtMbiemri.Text, DateTime.Parse(dtDiteLindja.Text), txtNrTelefonit.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, int.Parse(cmbRoliId.Text), txtAdresa.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Inserto te gjitha te dhenat e Puntorit");
            }
           
        }
    }
}
