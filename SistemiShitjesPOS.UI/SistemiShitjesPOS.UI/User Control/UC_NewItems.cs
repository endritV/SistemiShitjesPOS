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
    public partial class UC_NewItems : UserControl
    {
        public UC_NewItems()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnBackToUC_Items_Click(object sender, EventArgs e)
        {
            
  
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                string query = "spShtoArtikullin";
                SqlCommand da = new SqlCommand(query, x);
                da.CommandType = CommandType.StoredProcedure;
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
                MessageBox.Show(" Te dhenat u insertuan", o.ToString());
                x.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Inserto Te Dhenat Braqul");
            }


        }

        private void UC_NewItems_Load(object sender, EventArgs e)
        {

        }
    }
}
