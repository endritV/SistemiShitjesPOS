using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemiShitjesPOS.DAL;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewCustomers : UserControl
    {
        public UC_NewCustomers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
            x.Open();
            string query = "spShtoKlient";
            SqlCommand da = new SqlCommand(query, x);
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@_IdKlienti", txtIdEmployees.Text.ToString());
            da.Parameters.AddWithValue("@_Emri", txtEmri.Text.ToString());
            da.Parameters.AddWithValue("@_Adresa", txtAdresa.Text.ToString());
            da.Parameters.AddWithValue("@_NrTelefeoni", txtNrTelefonit.Text.ToString());

            if (rdbAktiv.Checked)
            {
                da.Parameters.AddWithValue("@_IsKlient", "1");
            }
            if (rdbJoAktiv.Checked)
            {
                da.Parameters.AddWithValue("@_IsKlient", "0");
            }
            int o = da.ExecuteNonQuery();
            MessageBox.Show(" Te dhenat u Ndryshuan", o.ToString());
            x.Close();

        }
          

    }
}
