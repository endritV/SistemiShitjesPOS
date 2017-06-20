using SistemiShitjesPOS.EntityLayer;
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
using SistemiShitjesPOS.BusinessLayer;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Items : UserControl
    {
        public UC_Items()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            try
            {
                dgListOfItems.DataSource = blItems.GetAll();
            }
            catch (Exception)
            {

                //MetroFramework.MetroMessageBox.Show(this, "Data Base is not conected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          


        }

        private void btnNewItems_Click(object sender, EventArgs e)
        {
            NewItems newItems = new NewItems();
            newItems.ShowDialog();
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            
            try
            {
                dgListOfItems.DataSource = blItems.SearchById(int.Parse(txtSearchItems.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Search with Barcode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }   

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchItems_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchItems.Clear();
        }

        

        private void panSearchItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgListOfItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfItems.Rows[e.RowIndex].Cells[0].Value.ToString();

            UpdateItems ui = new UpdateItems();

            ui.txtIdItems.Text = this.dgListOfItems.CurrentRow.Cells[4].Value.ToString();
            ui.txtEmri.Text = this.dgListOfItems.CurrentRow.Cells[5].Value.ToString();
            ui.txtBarkodi.Text = this.dgListOfItems.CurrentRow.Cells[3].Value.ToString();
            ui.txtPershkrimi.Text = this.dgListOfItems.CurrentRow.Cells[1].Value.ToString();
            ui.cmbCategory.Text = this.dgListOfItems.CurrentRow.Cells[2].Value.ToString();

            ui.ShowDialog();
        }
    }
}
