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
            this.txtDateTime.Text = DateTimeOffset.Now.ToString("MM - dd - yyyy");


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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdArtikulli,EmriArtikullit, Njesia, Pershkrimi, Cmimi FROM Artikulli where Barkodi = '" + newValue + "' ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //bool duple = false;
                    //for (int i = 0; i < dgListOfItems.Rows.Count; i++)
                    //{
                    //    if (newValue == dgListOfItems.Rows[i].Cells[0].Value.ToString())
                    //    {
                    //        duple = true;
                    //        MessageBox.Show("duple");
                    //        break;
                    //    }


                    //}
                    //if (!duple)
                    //{
                    dgListOfItems.Rows[e.RowIndex].Cells[1].Value = dt.Rows[0][0].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[2].Value = dt.Rows[0][1].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[3].Value = dt.Rows[0][2].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[4].Value = dt.Rows[0][3].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[5].Value = dt.Rows[0][4].ToString();
                    dgListOfItems.Rows[e.RowIndex].Cells[6].Value = 1.ToString();

                    con.Close();

                    //}




                }
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "This Barcode not Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            foreach (DataGridViewRow row in dgListOfItems.Rows)
            {

                int qnt = Convert.ToInt32(row.Cells[6].Value);



                if (Convert.ToString(row.Cells[6].Value) == qnt.ToString())
                {


                    row.Cells[dgListOfItems.Columns[7].Index].Value = (Convert.ToDouble(row.Cells[dgListOfItems.Columns[5].Index].Value) * Convert.ToDouble(row.Cells[dgListOfItems.Columns[6].Index].Value));
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

        private void btnCash_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgListOfItems.Rows.Count; i++)
            {
                SqlConnection con = new SqlConnection(DataBaseCon.GetConnectionString());
                SqlCommand cmd = new SqlCommand(@"INSERT INTO FaturaDetajet(IdFatura,IdArtikulli,Sasia,Cmimi,Data) VALUES ('" + dgListOfItems.Rows[i].Cells[8].Value + "','" + dgListOfItems.Rows[i].Cells[1].Value + "','" + dgListOfItems.Rows[i].Cells[6].Value + "','" + dgListOfItems.Rows[i].Cells[5].Value + "','" + dgListOfItems.Rows[i].Cells[9].Value + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Test");
                con.Close();
            }

            int a;
            SqlConnection conn = new SqlConnection(DataBaseCon.GetConnectionString());
            string query = "SELECT MAX (IdFatura) FROM FaturaDetajet";
            SqlCommand cmdd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtInvNo.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtInvNo.Text = a.ToString();
                }
                conn.Close();
            }
            dgListOfItems.Rows.Clear();
            label4.Text = "00.0";
            lblNoTax.Text = "00.0";
            lblTax.Text = "00.0";

        }

        private void dgListOfItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int row = 0;

            row = dgListOfItems.Rows.Count - 1;
            dgListOfItems["IdFatura", row].Value = txtInvNo.Text;
            dgListOfItems["DateTime", row].Value = txtDateTime.Text;
            //dgListOfItems["DateTime", row].Value = txtDateTime.Text;


            dgListOfItems.Refresh();


        }

        private void txtInvNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Dashboards_Load(object sender, EventArgs e)
        {
            int a;
            SqlConnection con = new SqlConnection(DataBaseCon.GetConnectionString());
            string query = "SELECT MAX (IdFatura) FROM FaturaDetajet";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtInvNo.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtInvNo.Text = a.ToString();
                }
                con.Close();
            }
            dgListOfItems.Rows.Clear();


        }

        private void dgListOfItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedVal = int.Parse(dgListOfItems.Rows[e.RowIndex].Cells[0].Value.ToString());


                foreach (DataGridViewRow row in dgListOfItems.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[6].Value == null)
                        break;

                if (int.Parse(row.Cells[0].Value.ToString()) == selectedVal ) 
                    {
                    

                        int temp = int.Parse(row.Cells[6].Value.ToString());
                        temp++;
                        row.Cells[6].Value = temp.ToString();
                        dgListOfItems.CurrentCell.Value = null;
                }
                }


        }


        private void dgListOfItems_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgListOfItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && dgListOfItems.CurrentCell.Value != null)
            {
                foreach (DataGridViewRow row in this.dgListOfItems.Rows)
                {
                    if (row.Index == this.dgListOfItems.CurrentCell.RowIndex)
                    { continue; }
                    if (this.dgListOfItems.CurrentCell.Value == null)
                    { continue; }
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == dgListOfItems.CurrentCell.Value.ToString())
                    {

                        dgListOfItems_CellContentClick(sender, e);
                        dgListOfItems.CurrentCell.Value = null;
                    }
                }
            }
        }
    }
}
