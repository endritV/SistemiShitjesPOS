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
            
            cmbSektoriId.DataSource = blSektori.GetAllSektori();
            

        }
        private void btnSubmitEmployees_Click(object sender, EventArgs e)
        {
            blEmployees.InsertNewEmployees(new Puntori(txtIdEmployees.Text, int.Parse(cmbSektoriId.Text), txtEmri.Text, txtMbiemri.Text, DateTime.Parse(dtDiteLindja.Text), txtNrTelefonit.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, int.Parse(cmbRoliId.Text), txtAdresa.Text));
        }
        private void txtIdEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            txtIdEmployees.Clear();
        }
        private void txtEmri_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmri.Clear();
        }

        private void txtMbiemri_MouseDown(object sender, MouseEventArgs e)
        {
            txtMbiemri.Clear(); 
        }

        private void txtNrTelefonit_MouseDown(object sender, MouseEventArgs e)
        {
            txtNrTelefonit.Clear();
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtAdresa_MouseDown(object sender, MouseEventArgs e)
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
    }
}
