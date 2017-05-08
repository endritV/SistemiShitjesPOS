﻿using System;
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
    public partial class UC_Items : UserControl
    {
        public UC_Items()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
            
        }

        private void btnNewItems_Click(object sender, EventArgs e)
        {
            UC_NewItems newItems = new UC_NewItems();
            panNew.Controls.Clear();
            panNew.Controls.Add(newItems);
        }

        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                SqlDataAdapter da = new SqlDataAdapter("spKerkoArtikullin " + txtSearchItems.Text.ToString(), x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgListOfItems.DataSource = dt;
                x.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Shkruaj Barkodin");
            }
         
        }   

        private void btnViewAll_Click(object sender, EventArgs e)
        {
           
           
                SqlConnection x = new SqlConnection(DataBaseCon.GetConnectionString());
                x.Open();
                SqlDataAdapter da = new SqlDataAdapter("spShfaqTeGjithaArtikujtv2", x);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgListOfItems.DataSource = dt;
                x.Close();
            
        
         

        }

        private void txtSearchItems_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchItems.Clear();
        }

        private void dgListOfItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dataValue = dgListOfItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            //panNew.Controls.Clear();
            //panNew.Controls.Add(n);
        }
    }
}
