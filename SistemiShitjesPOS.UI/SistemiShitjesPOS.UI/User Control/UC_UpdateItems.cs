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
        public Button btnUpdate;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private RadioButton rdbJoAktiv;
        private RadioButton rdbAktiv;
        private TextBox txtPershkrimi;
        private TextBox txtBarkodi;
        private TextBox txtEmri;
        private TextBox txtIdItems;
        public Button btnDelete;

        public UC_UpdateItems()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rdbJoAktiv = new System.Windows.Forms.RadioButton();
            this.rdbAktiv = new System.Windows.Forms.RadioButton();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.txtBarkodi = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtIdItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Location = new System.Drawing.Point(216, 618);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 30);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(379, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(216, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Plot the data for update Items";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Items";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Kg",
            "Li",
            "M"});
            this.cmbCategory.Location = new System.Drawing.Point(139, 270);
            this.cmbCategory.MaximumSize = new System.Drawing.Size(445, 0);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(445, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(445, 31);
            this.cmbCategory.TabIndex = 35;
            this.cmbCategory.Text = "Unity";
            // 
            // rdbJoAktiv
            // 
            this.rdbJoAktiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbJoAktiv.AutoSize = true;
            this.rdbJoAktiv.BackColor = System.Drawing.Color.Transparent;
            this.rdbJoAktiv.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbJoAktiv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJoAktiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbJoAktiv.Location = new System.Drawing.Point(379, 572);
            this.rdbJoAktiv.Name = "rdbJoAktiv";
            this.rdbJoAktiv.Size = new System.Drawing.Size(75, 24);
            this.rdbJoAktiv.TabIndex = 32;
            this.rdbJoAktiv.TabStop = true;
            this.rdbJoAktiv.Text = "Jo Aktiv";
            this.rdbJoAktiv.UseVisualStyleBackColor = false;
            // 
            // rdbAktiv
            // 
            this.rdbAktiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbAktiv.AutoSize = true;
            this.rdbAktiv.BackColor = System.Drawing.Color.Transparent;
            this.rdbAktiv.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbAktiv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAktiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbAktiv.Location = new System.Drawing.Point(282, 572);
            this.rdbAktiv.Name = "rdbAktiv";
            this.rdbAktiv.Size = new System.Drawing.Size(56, 24);
            this.rdbAktiv.TabIndex = 33;
            this.rdbAktiv.TabStop = true;
            this.rdbAktiv.Text = "Aktiv";
            this.rdbAktiv.UseVisualStyleBackColor = false;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPershkrimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtPershkrimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPershkrimi.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPershkrimi.Location = new System.Drawing.Point(139, 319);
            this.txtPershkrimi.MaximumSize = new System.Drawing.Size(445, 248);
            this.txtPershkrimi.MinimumSize = new System.Drawing.Size(445, 248);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(445, 248);
            this.txtPershkrimi.TabIndex = 28;
            this.txtPershkrimi.Text = "Info";
            // 
            // txtBarkodi
            // 
            this.txtBarkodi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarkodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtBarkodi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodi.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarkodi.Location = new System.Drawing.Point(139, 216);
            this.txtBarkodi.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtBarkodi.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtBarkodi.Name = "txtBarkodi";
            this.txtBarkodi.Size = new System.Drawing.Size(445, 32);
            this.txtBarkodi.TabIndex = 29;
            this.txtBarkodi.Text = "Barcodes";
            // 
            // txtEmri
            // 
            this.txtEmri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmri.Location = new System.Drawing.Point(139, 164);
            this.txtEmri.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(445, 32);
            this.txtEmri.TabIndex = 30;
            this.txtEmri.Text = "Name";
            // 
            // txtIdItems
            // 
            this.txtIdItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdItems.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdItems.Location = new System.Drawing.Point(139, 116);
            this.txtIdItems.Name = "txtIdItems";
            this.txtIdItems.ReadOnly = true;
            this.txtIdItems.Size = new System.Drawing.Size(128, 32);
            this.txtIdItems.TabIndex = 31;
            this.txtIdItems.Text = "Product ID";
            // 
            // UC_UpdateItems
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rdbJoAktiv);
            this.Controls.Add(this.rdbAktiv);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.txtBarkodi);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtIdItems);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
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
