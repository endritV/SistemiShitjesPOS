using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.DAL;
using System.Data.SqlClient;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnNewEmployees_Click(object sender, EventArgs e)
        {
            UC_NewEmployees newEmloyees = new UC_NewEmployees();
            panEmployees.Controls.Clear();
            panEmployees.Controls.Add(newEmloyees);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
            x.Open();
            SqlDataAdapter da = new SqlDataAdapter("spShfaqTeGjithePuntoret", x);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgEmployees.DataSource = dt;
            x.Close();

        }

        private void txtSearchEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                SqlDataAdapter da = new SqlDataAdapter("spKerkoPuntorin " + txtSearchEmployees.Text.ToString(), x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgEmployees.DataSource = dt;
                x.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Shkruani info rreth puntorit");
            }
        }

        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
