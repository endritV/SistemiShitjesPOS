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

                dgListOfItems.Rows.Add(row.Cells[4].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());


            }


            //foreach (DataGridViewRow row in dgListOfItems.Rows)
            //{
            //    row.Cells[dgListOfItems.Columns["UnityPrice"].Index].Value = (Convert.ToDouble(row.Cells[dgListOfItems.Columns["Price"].Index].Value) * Convert.ToDouble(row.Cells[dgListOfItems.Columns["Quantity"].Index].Value));
            //}









        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgListOfItems.Rows.Clear();
            label4.Text = "00.0";
            lblNoTax.Text = "00.0";
            lblTax.Text = "00.0";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgListOfItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                //foreach (DataGridViewRow row in dgListOfItems.Rows)
                //{

                //    row.Cells[dgListOfItems.Columns["UnityPrice"].Index].Value = (Convert.ToDouble(row.Cells[dgListOfItems.Columns["Price"].Index].Value) * Convert.ToDouble(row.Cells[dgListOfItems.Columns["Quantity"].Index].Value));
                //    dgListOfItems.Refresh();

                //    double sum = 0;
                //    double a = 0.16;
                //    for (int i = 0; i < dgListOfItems.Rows.Count; ++i)
                //    {
                //        sum += Convert.ToDouble(dgListOfItems.Rows[i].Cells[7].Value);
                //    }

                //    lblNoTax.Text = Convert.ToString(sum - (a * sum));
                //    lblTax.Text = Convert.ToString(a * sum);
                //    label4.Text = sum.ToString();



                //}

            }
        }

        public AutoCompleteStringCollection ItemsListDropDown()
        {
            SqlConnection con = new SqlConnection(DataBaseCon.GetConnectionString());
            AutoCompleteStringCollection asc = new AutoCompleteStringCollection();
            try
            {
                string query;
                query = "SELECT Barkodi FROM Artikulli";

                SqlCommand com = new SqlCommand(query, con);

                SqlDataReader dr;
                con.Open();

                dr = com.ExecuteReader();
                if ((dr != null) && (dr.HasRows))
                {
                    while (dr.Read())
                    {
                        asc.Add(dr.GetValue(0).ToString());
                    }
                    dr.Close();
                    com.Dispose();
                    con.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return asc;
        }

        private void dgListOfItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgListOfItems.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    prodCode.AutoCompleteCustomSource = ItemsListDropDown();
                    prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    TextBox prodCode1 = e.Control as TextBox;
                    if (prodCode1 != null)
                    {
                        prodCode1.AutoCompleteMode = AutoCompleteMode.None;
                    }
                }
            }
        }

        private void dgListOfItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DataBaseCon.GetConnectionString());
                if (e.ColumnIndex == 0)
                {
                    string newValue;

                    newValue = (dgListOfItems[e.ColumnIndex, e.RowIndex].Value).ToString();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdArtikulli,EmriArtikullit, Njesia, Pershkrimi, Cmimi FROM Artikulli where Barkodi = '" + newValue + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgListOfItems.Rows[e.RowIndex].Cells[1].Value = dt.Rows[0][0].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[2].Value = dt.Rows[0][1].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[3].Value = dt.Rows[0][2].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[4].Value = dt.Rows[0][3].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[5].Value = dt.Rows[0][4].ToString();

                    con.Close();
                }
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "This Barcode not Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            foreach (DataGridViewRow row in dgListOfItems.Rows)
            {
                int qnt = Convert.ToInt32(row.Cells[6].Value = 1);

                if (Convert.ToString(row.Cells[6].Value) == qnt.ToString())
                {


                    row.Cells[dgListOfItems.Columns["UnityPrice"].Index].Value = (Convert.ToDouble(row.Cells[dgListOfItems.Columns["Price"].Index].Value) * Convert.ToDouble(row.Cells[dgListOfItems.Columns["Quantity"].Index].Value));
                    dgListOfItems.Refresh();

                    double sum = 0;
                    double a = 0.16;
                    for (int i = 0; i < dgListOfItems.Rows.Count; ++i)
                    {
                        sum += Convert.ToDouble(dgListOfItems.Rows[i].Cells[7].Value);
                    }

                    lblNoTax.Text = Convert.ToString(sum - (a * sum));
                    lblTax.Text = Convert.ToString(a * sum);
                    label4.Text = sum.ToString();
                }


            }

        }
    }

}
