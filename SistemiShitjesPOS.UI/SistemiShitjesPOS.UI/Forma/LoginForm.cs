using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SistemiShitjesPOS.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DashBoard dx = new DashBoard();

            SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
            string query = "spLoginKredenciale";
            SqlCommand da = new SqlCommand(query, x);
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@_Username", txbUsername.Text.ToString());
            da.Parameters.AddWithValue("@_Passwordi", txbPassword.Text.ToString());
            x.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(da);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            x.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                this.Visible = false;
                dx.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!!");
            } 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
