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
    public partial class UC_UpdateItems : UserControl
    {
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                string query = "spNdryshoAritkullin";
                SqlCommand da = new SqlCommand(query, x);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@_IdArtikulli", txtIdItems.Text.ToString());
                da.Parameters.AddWithValue("@_EmriArtikullit", txtEmri.Text.ToString());
                da.Parameters.AddWithValue("@_Barkodi", txtBarkodi.Text.ToString());
                da.Parameters.AddWithValue("@_Pershkrimi", txtPershkrimi.Text.ToString());
                da.Parameters.AddWithValue("@_Njesia", cmbCategory.Text.ToString());

                if (rdbAktiv.Checked)
                {
                    da.Parameters.AddWithValue("@_IsAktvi", "1");
                }
                if (rdbJoAktiv.Checked)
                {
                    da.Parameters.AddWithValue("@_IsAktvi", "0");
                }
                int o = da.ExecuteNonQuery();
                MessageBox.Show(" Te dhenat u ndryshuan", o.ToString());
                x.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ju lutem Ndryshoni te gjitha te dhenat");
            }
        

        }

    }
}

