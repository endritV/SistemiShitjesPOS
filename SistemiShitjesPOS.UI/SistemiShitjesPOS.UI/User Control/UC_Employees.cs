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
using SistemiShitjesPOS.DataAccessLayer;
using System.Data.SqlClient;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            try
            {
                dgEmployees.DataSource = blEmployees.GetAll();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Data Base in not conected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btnNewEmployees_Click(object sender, EventArgs e)
        {
            NewEmployees newEmployees = new NewEmployees();
            newEmployees.ShowDialog();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            

        }

        private void txtSearchEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                dgEmployees.DataSource = blEmployees.GetEmplyoeeById(txtSearchEmployees.Text);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Search with Id Employees ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void txtSearchEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchEmployees.Clear();
        }

        private void dgEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();

            UpdateEmployees ue = new UpdateEmployees();
            ue.txtIdEmployees.Text = this.dgEmployees.CurrentRow.Cells[10].Value.ToString();
            ue.txtEmri.Text = this.dgEmployees.CurrentRow.Cells[8].Value.ToString();
            ue.txtMbiemri.Text = this.dgEmployees.CurrentRow.Cells[7].Value.ToString();
            ue.txtUserName.Text = this.dgEmployees.CurrentRow.Cells[3].Value.ToString();
            ue.txtPassword.Text = this.dgEmployees.CurrentRow.Cells[2].Value.ToString();
            ue.txtNrTelefonit.Text = this.dgEmployees.CurrentRow.Cells[5].Value.ToString();
            ue.txtEmail.Text = this.dgEmployees.CurrentRow.Cells[4].Value.ToString();
            ue.txtAdresa.Text = this.dgEmployees.CurrentRow.Cells[0].Value.ToString();
            ue.cmbRoliId.Text = this.dgEmployees.CurrentRow.Cells[1].Value.ToString();
            ue.cmbSektoriId.Text = this.dgEmployees.CurrentRow.Cells[9].Value.ToString();
            ue.dtDiteLindja.Text = this.dgEmployees.CurrentRow.Cells[6].Value.ToString();

            ue.ShowDialog();
        }
    }
}
