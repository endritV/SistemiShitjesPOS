using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_UpdateItems : UserControl
    {
        public ComboBox cmbCategory;
        public Button btnSubmit;
        public Button btnDelete;
        public RadioButton rdbJoAktiv;
        public RadioButton rdbAktiv;
        public TextBox txtPershkrimi;
        public TextBox txtBarkodi;
        public TextBox txtEmri;
        public TextBox txtIdItems;

        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rdbJoAktiv = new System.Windows.Forms.RadioButton();
            this.rdbAktiv = new System.Windows.Forms.RadioButton();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.txtBarkodi = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtIdItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Kg",
            "Li",
            "M"});
            this.cmbCategory.Location = new System.Drawing.Point(26, 305);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(182, 31);
            this.cmbCategory.TabIndex = 22;
            this.cmbCategory.Text = "Unity";
            this.cmbCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbCategory_MouseDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmit.Location = new System.Drawing.Point(434, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 30);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(614, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rdbJoAktiv
            // 
            this.rdbJoAktiv.AutoSize = true;
            this.rdbJoAktiv.BackColor = System.Drawing.Color.Transparent;
            this.rdbJoAktiv.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJoAktiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbJoAktiv.Location = new System.Drawing.Point(123, 394);
            this.rdbJoAktiv.Name = "rdbJoAktiv";
            this.rdbJoAktiv.Size = new System.Drawing.Size(75, 24);
            this.rdbJoAktiv.TabIndex = 18;
            this.rdbJoAktiv.TabStop = true;
            this.rdbJoAktiv.Text = "Jo Aktiv";
            this.rdbJoAktiv.UseVisualStyleBackColor = false;
            // 
            // rdbAktiv
            // 
            this.rdbAktiv.AutoSize = true;
            this.rdbAktiv.BackColor = System.Drawing.Color.Transparent;
            this.rdbAktiv.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAktiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbAktiv.Location = new System.Drawing.Point(26, 394);
            this.rdbAktiv.Name = "rdbAktiv";
            this.rdbAktiv.Size = new System.Drawing.Size(56, 24);
            this.rdbAktiv.TabIndex = 19;
            this.rdbAktiv.TabStop = true;
            this.rdbAktiv.Text = "Aktiv";
            this.rdbAktiv.UseVisualStyleBackColor = false;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtPershkrimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPershkrimi.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPershkrimi.Location = new System.Drawing.Point(312, 88);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(400, 248);
            this.txtPershkrimi.TabIndex = 14;
            this.txtPershkrimi.Text = "Info";
            this.txtPershkrimi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPershkrimi_MouseDown);
            // 
            // txtBarkodi
            // 
            this.txtBarkodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtBarkodi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodi.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarkodi.Location = new System.Drawing.Point(26, 230);
            this.txtBarkodi.Name = "txtBarkodi";
            this.txtBarkodi.Size = new System.Drawing.Size(182, 32);
            this.txtBarkodi.TabIndex = 15;
            this.txtBarkodi.Text = "Barcodes";
            this.txtBarkodi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBarkodi_MouseDown);
            // 
            // txtEmri
            // 
            this.txtEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmri.Location = new System.Drawing.Point(26, 156);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(182, 32);
            this.txtEmri.TabIndex = 16;
            this.txtEmri.Text = "Name";
            this.txtEmri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEmri_MouseDown);
            // 
            // txtIdItems
            // 
            this.txtIdItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdItems.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdItems.Location = new System.Drawing.Point(26, 88);
            this.txtIdItems.Name = "txtIdItems";
            this.txtIdItems.Size = new System.Drawing.Size(182, 32);
            this.txtIdItems.TabIndex = 17;
            this.txtIdItems.Text = "Product ID";
            this.txtIdItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtIdItems_MouseDown);
            // 
            // UC_UpdateItems
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rdbJoAktiv);
            this.Controls.Add(this.rdbAktiv);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.txtBarkodi);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtIdItems);
            this.Name = "UC_UpdateItems";
            this.Size = new System.Drawing.Size(754, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                blItems.UpdateItem(new Artikulli(int.Parse(txtIdItems.Text), txtEmri.Text, int.Parse(txtBarkodi.Text), txtPershkrimi.Text, cmbCategory.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Inserto te gjitha te dhenat");
            }
            


            //try
            //{

            //    SqlConnection x = new SqlConnection(DataBaseCon.Connection);
            //    x.Open();
            //    string query = "spShtoArtikullin";
            //    SqlCommand da = new SqlCommand(query, x);
            //    da.CommandType = CommandType.StoredProcedure;
            //    da.Parameters.AddWithValue("@_EmriArtikullit", txtEmri.Text.ToString());
            //    da.Parameters.AddWithValue("@_Barkodi", txtBarkodi.Text.ToString());
            //    da.Parameters.AddWithValue("@_Pershkrimi", txtPershkrimi.Text.ToString());
            //    da.Parameters.AddWithValue("@_Njesia", cmbCategory.Text.ToString());

            //    if (rdbAktiv.Checked)
            //    {
            //        da.Parameters.AddWithValue("@_IsAktvi", "1");
            //    }
            //    if (rdbJoAktiv.Checked)
            //    {
            //        da.Parameters.AddWithValue("@_IsAktvi", "0");
            //    }
            //    int o = da.ExecuteNonQuery();
            //    MessageBox.Show(" Te dhenat u insertuan", o.ToString());
            //    x.Close();

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Inserto Te Dhenat Braqul");
            //}
        }

        private void txtIdItems_MouseDown(object sender, MouseEventArgs e)
        {
            txtIdItems.Clear();
        }

        private void txtEmri_MouseDown(object sender, MouseEventArgs e)
        {
            txtEmri.Clear();
        }

        private void txtBarkodi_MouseDown(object sender, MouseEventArgs e)
        {
            txtBarkodi.Clear();
        }

        private void txtPershkrimi_MouseDown(object sender, MouseEventArgs e)
        {
            txtPershkrimi.Clear();
        }

        private void cmbCategory_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                blItems.DeleteArtikulli(Int32.Parse(txtBarkodi.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Inserto Barkodin e Artikullit");
            }
            
        }
    }
}
