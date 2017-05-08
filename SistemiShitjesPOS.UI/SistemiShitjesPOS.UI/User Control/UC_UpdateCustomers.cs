using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_UpdateCustomers : UserControl
    {
        public UC_UpdateCustomers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        //    SqlConnection x = new SqlConnection(DataBaseCon.Connection);
        //    x.Open();
        //    string query = "spNdryshoKlientin";
        //    SqlCommand da = new SqlCommand(query, x);
        //    da.CommandType = CommandType.StoredProcedure;
        //    da.Parameters.AddWithValue("@_IdKlienti", txtIdEmployee.Text.ToString());
        //    da.Parameters.AddWithValue("@_Emri", txtEmri.Text.ToString());
        //    da.Parameters.AddWithValue("@_Adresa", txtAdresa.Text.ToString());
        //    da.Parameters.AddWithValue("@_NrTelefeoni", txtNrTel.Text.ToString());

        //    if (rdbAktiv.Checked)
        //    {
        //        da.Parameters.AddWithValue("@_IsKlient", "1");
        //    }
        //    else if (rdbJoAktiv.Checked)
        //    {
        //        da.Parameters.AddWithValue("@_IsKlient", "0");
        //    }
        //    int o = da.ExecuteNonQuery();
        //    MessageBox.Show(" Te dhenat u Ndryshuan", o.ToString());
        //    x.Close();
        }
    }
}
