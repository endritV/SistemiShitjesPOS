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
using SistemiShitjesPOS.DAL;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Suppilers : UserControl
    {
        public UC_Suppilers()
        {
            InitializeComponent();
        }

        private void btnNewSuppliers_Click(object sender, EventArgs e)
        {
            UC_NewSuppliers newSuppliers = new UC_NewSuppliers();
            panSuppliers.Controls.Clear();
            panSuppliers.Controls.Add(newSuppliers);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
            x.Open();
            SqlDataAdapter da = new SqlDataAdapter("spShfaqTeGjitheFurnizuesit", x);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgListOfSuppliers.DataSource = dt;
            x.Close();

        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                SqlDataAdapter da = new SqlDataAdapter("spKerkoArtikullin " + txtSearchSuppliers.Text.ToString(), x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgListOfSuppliers.DataSource = dt;
                x.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Shkruaj Id-n e Klientit");
            }
        }

        private void dgListOfSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string dataValue = dgListOfSuppliers.Rows[e.RowIndex].Cells[1].Value.ToString();

            //UC_Items u = new UC_Items();
            //panSuppliers.Controls.Clear();
            //panSuppliers.Controls.Add(u);
            //try
            //{
            //    if (e.RowIndex >= 0)
            //    {

            //        DataGridViewRow row = this.dgListOfSuppliers.Rows[e.RowIndex];

            //        //u.txtIdItems.Text = row.Cells[0].Value.ToString();
            //        //u.txtEmri.Text = row.Cells[1].Value.ToString();
            //        //u.txtBarkodi.Text = row.Cells[2].Value.ToString();
            //        //u.cmbCategory.SelectedText = row.Cells[3].Value.ToString();
            //        //u.txtPershkrimi.Text = row.Cells[4].Value.ToString();


            //    }

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Selekto nje rresht");
            //}
        }
    }
}
