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
            dgListOfSuppliers.DataSource = blSupplier.GETALL();
        }

        private void btnNewSuppliers_Click(object sender, EventArgs e)
        {
            UC_NewSuppliers newSuppliers = new UC_NewSuppliers();
            panSuppliers.Controls.Clear();
            panSuppliers.Controls.Add(newSuppliers);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        //    SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
        //    x.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("spShfaqTeGjitheFurnizuesit", x);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgListOfSuppliers.DataSource = dt;
        //    x.Close();

        //}

        //private void btnSearchSuppliers_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection x = new SqlConnection(DataBaseCon.Connection);
        //        x.Open();
        //        SqlDataAdapter da = new SqlDataAdapter("spKerkoFurnizuesin " + txtSearchSuppliers.Text.ToString(), x);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dgListOfSuppliers.DataSource = dt;
        //        x.Close();

        //}
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Shkruaj Id-n e Klientit");
        //    }
}

        private void dgListOfSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfSuppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
            UC_UpdateSuppliers u = new UC_UpdateSuppliers();


            panSuppliers.Controls.Clear();
            panSuppliers.Controls.Add(u);
            //    try
            //    {
            //        if (e.RowIndex >= 0)
            //        {


            //            DataGridViewRow row = this.dgListOfSuppliers.Rows[e.RowIndex];



            //            u.txtIdSuppliers.Text = row.Cells[0].Value.ToString();
            //            u.txtEmri.Text = row.Cells[1].Value.ToString();
            //            u.txtEmriFurnitorit.Text = row.Cells[2].Value.ToString();
            //            u.txtMbiemri.SelectedText = row.Cells[3].Value.ToString();
            //            u.txtAdresa.Text = row.Cells[4].Value.ToString();
            //            u.txtNrFix.Text = row.Cells[5].Value.ToString();
            //            u.txtNrTelefonit.Text = row.Cells[6].Value.ToString();
            //            u.txtNrBiznesit.Text = row.Cells[7].Value.ToString();
            //            u.txtEmail.Text = row.Cells[8].Value.ToString();
            //            u.txtWeb.Text = row.Cells[9].Value.ToString();
            //            u.txtpershkrimi.Text = row.Cells[10].Value.ToString();



            //        }

            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Selekto nje rresht");
            //    }
            //}
        }
        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            dgListOfSuppliers.DataSource = blSupplier.GetSupplierByid(txtSearchSuppliers.Text);
        }

        private void txtSearchSuppliers_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchSuppliers.Clear();
        }
    }
}
