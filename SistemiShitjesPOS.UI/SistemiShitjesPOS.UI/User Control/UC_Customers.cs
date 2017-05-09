using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.UI;
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


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dgListOfCustomers.DataSource = dalKlineti.GetAll();
        }

        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            UC_NewCustomers newCustomers = new UC_NewCustomers();
            panCustomers.Controls.Clear();
            panCustomers.Controls.Add(newCustomers);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            dgListOfCustomers.DataSource = blKlienti.SearchById(txtSearchCustomers.Text);

        }

        private void dgListOfCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();

            UC_UpdateCustomers u = new UC_UpdateCustomers();

            panCustomers.Controls.Clear();
            panCustomers.Controls.Add(u);

            //try
            //{
            //    if (e.RowIndex >= 0)
            //    {

            //        DataGridViewRow row = this.dgListOfCustomers.Rows[e.RowIndex];

            //        u.txtIdEmployee.Text = row.Cells[0].Value.ToString();
            //        u.txtEmri.Text = row.Cells[1].Value.ToString();
            //        u.txtAdresa.Text = row.Cells[2].Value.ToString();
            //        u.txtNrTel.Text = row.Cells[3].Value.ToString();

                    


            //    }

            //}
            //catch (Exception)
            //{

                
            //}
        }

        private void txtSearchCustomers_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchCustomers.Clear();
        }
    }
}
