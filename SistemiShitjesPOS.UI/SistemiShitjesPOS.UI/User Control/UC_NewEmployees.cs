using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.DataAccessLayer;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewEmployees : UserControl
    {
        static string cs = DataBaseCon.GetConnectionString();
        public UC_NewEmployees()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            try
            {
                cmbSektoriId.DataSource = blSektori.GetAllSektori();
            }
            catch (Exception)
            {
                MessageBox.Show("Nuk eshte ne rregull");
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

                MessageBox.Show("Shkruaj te gjitha te dhenat");
            }
            
        }
        private void txtIdEmployees_TextChanged(object sender, MouseEventArgs e)
        {
            txtIdEmployees.Clear();
        }


        private void txtMbiemri_TextChanged(object sender, MouseEventArgs e)
        {
            txtMbiemri.Clear(); 
        }

        private void txtNrTelefonit_TextChanged(object sender, MouseEventArgs e)
        {
            txtNrTelefonit.Clear();
        }

        private void txtEmail_TextChanged(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtUserName_TextChanged(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_TextChanged(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtAdresa_TextChanged(object sender, MouseEventArgs e)
        {
            txtAdresa.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        protected void cmbSektoriId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSektoriId_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void txtEmri_TextChanged(object sender, EventArgs e)
        {
            txtEmri.Clear();
        }
    }
}
