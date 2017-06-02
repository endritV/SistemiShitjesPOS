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
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Suppilers : UserControl
    {
        public UC_Suppilers()
        {
            InitializeComponent();
            try
            {
                dgListOfSuppliers.DataSource = blSupplier.GETALL();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Data Base is not Connected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Dock = DockStyle.Fill;
           

        }

        private void btnNewSuppliers_Click(object sender, EventArgs e)
        {
            NewSuppliers newSuppliers = new NewSuppliers();
            newSuppliers.ShowDialog();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                dgListOfSuppliers.DataSource = blSupplier.GetSupplierByid(txtSearchSuppliers.Text);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Search by Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtSearchSuppliers_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchSuppliers.Clear();
        }

        private void dgListOfSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfSuppliers.Rows[e.RowIndex].Cells[1].Value.ToString();

            UpdateSuppliers u = new UpdateSuppliers();

            u.txtIdSuppliers.Text = this.dgListOfSuppliers.CurrentRow.Cells[11].Value.ToString();
            
            u.txtEmriFurnitorit.Text = this.dgListOfSuppliers.CurrentRow.Cells[9].Value.ToString();
            u.txtMbiemri.SelectedText = this.dgListOfSuppliers.CurrentRow.Cells[8].Value.ToString();
            u.txtAdresa.Text = this.dgListOfSuppliers.CurrentRow.Cells[6].Value.ToString();
            u.txtNrFix.Text = this.dgListOfSuppliers.CurrentRow.Cells[7].Value.ToString();
            u.txtNrTelefonit.Text = this.dgListOfSuppliers.CurrentRow.Cells[5].Value.ToString();
            u.txtNrBiznesit.Text = this.dgListOfSuppliers.CurrentRow.Cells[4].Value.ToString();
            u.txtEmail.Text = this.dgListOfSuppliers.CurrentRow.Cells[2].Value.ToString();
            u.txtWeb.Text = this.dgListOfSuppliers.CurrentRow.Cells[1].Value.ToString();
            u.txtpershkrimi.Text = this.dgListOfSuppliers.CurrentRow.Cells[3].Value.ToString();

            u.ShowDialog();

        }
    }
}
