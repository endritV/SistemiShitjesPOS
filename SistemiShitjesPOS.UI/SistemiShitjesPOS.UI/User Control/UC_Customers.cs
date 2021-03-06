﻿using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.DataAccessLayer;
using System;
using System.Windows.Forms;


namespace SistemiShitjesPOS.UI
{
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           
            try
            {
                dgListOfCustomers.DataSource = blKlienti.GETALL();
            }
            catch (Exception)
            {

                //MetroFramework.MetroMessageBox.Show(this, "Data Base not conected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            NewCustomers newCustomers = new NewCustomers();
            newCustomers.ShowDialog();
           
            
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }
      
        protected void btnSearchCustomers_Click(object sender, EventArgs e)
        {
         
            try
            {
                dgListOfCustomers.DataSource = blKlienti.SearchById(txtSearchCustomers.Text);
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Insert Id Client", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

       
        private void txtSearchCustomers_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchCustomers.Clear();
        }

       

        private void dgListOfCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string dataValue = dgListOfCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();

                UpdateCustomers uc = new UpdateCustomers();

                uc.txtCustomersId.Text = this.dgListOfCustomers.CurrentRow.Cells[2].Value.ToString();
                uc.txtEmri.Text = this.dgListOfCustomers.CurrentRow.Cells[3].Value.ToString();
                uc.txtNrTel.Text = this.dgListOfCustomers.CurrentRow.Cells[4].Value.ToString();
                uc.txtAdresa.Text = this.dgListOfCustomers.CurrentRow.Cells[5].Value.ToString();
                

                uc.ShowDialog();
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Click in Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panCustomers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchCustomers.Text;
            dgListOfCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
                
                foreach (DataGridViewRow row in dgListOfCustomers.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgListOfCustomers.Rows[rowIndex].Selected = true;
                            
                            break;
                        }
                    }
                } 
        }
    }
}
