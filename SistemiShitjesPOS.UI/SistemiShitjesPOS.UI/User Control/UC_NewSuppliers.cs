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
    public partial class UC_NewSuppliers : UserControl
    {
        public UC_NewSuppliers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                string query = "spShtoFurnizuesin";
                SqlCommand da = new SqlCommand(query, x);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@_IdKlienti", txtIdSuppliers.Text.ToString());
                da.Parameters.AddWithValue("@_Emri", txtEmri.Text.ToString());
                da.Parameters.AddWithValue("@_EmriPronarit", txtEmriFurnitorit.Text.ToString());
                da.Parameters.AddWithValue("@_MbiemriPronarit", txtMbiemri.Text.ToString());
                da.Parameters.AddWithValue("@_Adresa", txtAdresa.Text.ToString());
                da.Parameters.AddWithValue("@_NrFix", txtNrFix.Text.ToString());
                da.Parameters.AddWithValue("@_Nrtelefonit", txtNrTelefonit.Text.ToString());
                da.Parameters.AddWithValue("@_NrBiznesit", txtNrBiznesit.Text.ToString());
                da.Parameters.AddWithValue("@_Email", txtEmail.Text.ToString());
                da.Parameters.AddWithValue("@_Web", txtWeb.Text.ToString());
                da.Parameters.AddWithValue("@_Pershkrimi", txtpershkrimi.Text.ToString());

                if (rdbAktiv.Checked)
                {
                    da.Parameters.AddWithValue("@_IsKlient", "1");
                }
                if (rdbJoAktiv.Checked)
                {
                    da.Parameters.AddWithValue("@_IsKlient", "0");
                }
                int o = da.ExecuteNonQuery();
                MessageBox.Show(" Te dhenat u insertuan", o.ToString());
                x.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("Inserto Te Dhenat Braqul");
            }
}

        private void UC_NewSuppliers_Load(object sender, EventArgs e)
        {

        }
    }
}
