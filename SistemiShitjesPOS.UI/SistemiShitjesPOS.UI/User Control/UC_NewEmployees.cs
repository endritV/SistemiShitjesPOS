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
    public partial class UC_NewEmployees : UserControl
    {
        public UC_NewEmployees()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnSubmitEmployees_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                string query = "spShtoPuntorin";
                SqlCommand da = new SqlCommand(query, x);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@_IdPuntori", txtIdEmployees.Text.ToString());
                da.Parameters.AddWithValue("@_IdSektori", cmbSektoriId.Text.ToString());
                da.Parameters.AddWithValue("@_IdRoli", cmbRoliId.Text.ToString());
                da.Parameters.AddWithValue("@_Emri", txtEmri.Text.ToString());
                da.Parameters.AddWithValue("@_Mbiemri", txtMbiemri.Text.ToString());
                da.Parameters.AddWithValue("@_DataLindjes", dtDiteLindja.Text.ToString());
                da.Parameters.AddWithValue("@_Adresa", txtAdresa.Text.ToString());
                da.Parameters.AddWithValue("@_NrTelefonit", txtNrTelefonit.Text.ToString());
                da.Parameters.AddWithValue("@_Email", txtEmail.Text.ToString());
                da.Parameters.AddWithValue("@_UserName", txtUserName.Text.ToString());
                da.Parameters.AddWithValue("@_Password", txtPassword.Text.ToString());


                int o = da.ExecuteNonQuery();
                MessageBox.Show(" Te dhenat u insertuan", o.ToString());
                x.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Inserto Te Dhenat Braqul");
            }
        }
    }
}
