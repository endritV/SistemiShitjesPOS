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
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Dashboards : UserControl
    {
        public UC_Dashboards()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy \n     hh:mm");
            lblDateTime.Refresh();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
         
                
             
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panCmimi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {
            
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgSearch.DataSource = blItems.SearchById(int.Parse(txtKerko.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Search with Barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnShto_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dgSearch.Rows)
            {
                dgListOfItems.Rows.Add(row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString());
                

            }



           
            //DataGridViewColumn newCol = null;
            //foreach (DataGridViewColumn col in dgSearch.Columns)
            //{
            //    newCol = new DataGridViewColumn(col.CellTemplate);
            //    newCol.HeaderText = col.HeaderText;
            //    newCol.Name = col.Name;
            //    dgListOfItems.Columns.Add(newCol);
            //}

            //dgListOfItems.RowCount = dgSearch.RowCount;
            //foreach (DataGridViewRow row in dgSearch.Rows)
            //{
            //    foreach (DataGridViewColumn col in dgSearch.Columns)
            //    {
            //        dgListOfItems.Rows[row.Index].Cells[col.Name].Value = row.Cells[col.Name].Value;
            //    }
            //}

        }

    }
}
