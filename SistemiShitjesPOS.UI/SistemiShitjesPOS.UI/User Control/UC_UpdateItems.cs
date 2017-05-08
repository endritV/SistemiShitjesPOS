using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_UpdateItems : UserControl
    {
        private ComboBox cmbCategory;
        private Button btnSubmit;
        private Button btnBackToUC_Items;
        private RadioButton rdbJoAktiv;
        private RadioButton rdbAktiv;
        private TextBox txtPershkrimi;
        private TextBox txtBarkodi;
        private TextBox txtEmri;
        private TextBox txtIdItems;

        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToUC_Items = new System.Windows.Forms.Button();
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
            // 
            // btnBackToUC_Items
            // 
            this.btnBackToUC_Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBackToUC_Items.FlatAppearance.BorderSize = 0;
            this.btnBackToUC_Items.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnBackToUC_Items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnBackToUC_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToUC_Items.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToUC_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackToUC_Items.Location = new System.Drawing.Point(614, 481);
            this.btnBackToUC_Items.Name = "btnBackToUC_Items";
            this.btnBackToUC_Items.Size = new System.Drawing.Size(98, 30);
            this.btnBackToUC_Items.TabIndex = 20;
            this.btnBackToUC_Items.Text = "Back";
            this.btnBackToUC_Items.UseVisualStyleBackColor = false;
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
            // 
            // txtIdItems
            // 
            this.txtIdItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdItems.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdItems.Location = new System.Drawing.Point(26, 88);
            this.txtIdItems.Name = "txtIdItems";
            this.txtIdItems.ReadOnly = true;
            this.txtIdItems.Size = new System.Drawing.Size(182, 32);
            this.txtIdItems.TabIndex = 17;
            this.txtIdItems.Text = "Product ID";
            // 
            // UC_UpdateItems
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBackToUC_Items);
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
    }
}
