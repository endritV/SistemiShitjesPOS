namespace SistemiShitjesPOS.UI
{
    partial class UC_Suppilers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panSuppliers = new System.Windows.Forms.Panel();
            this.panSearchItems = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnNewSuppliers = new System.Windows.Forms.Button();
            this.btnSearchSuppliers = new System.Windows.Forms.Button();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lblListOfSuppliers = new System.Windows.Forms.Label();
            this.dgListOfSuppliers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panSuppliers.SuspendLayout();
            this.panSearchItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panSuppliers
            // 
            this.panSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSuppliers.Controls.Add(this.panSearchItems);
            this.panSuppliers.Controls.Add(this.lblListOfSuppliers);
            this.panSuppliers.Controls.Add(this.dgListOfSuppliers);
            this.panSuppliers.Controls.Add(this.label1);
            this.panSuppliers.Location = new System.Drawing.Point(0, 0);
            this.panSuppliers.Name = "panSuppliers";
            this.panSuppliers.Size = new System.Drawing.Size(754, 567);
            this.panSuppliers.TabIndex = 5;
            // 
            // panSearchItems
            // 
            this.panSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panSearchItems.Controls.Add(this.btnViewAll);
            this.panSearchItems.Controls.Add(this.btnNewSuppliers);
            this.panSearchItems.Controls.Add(this.btnSearchSuppliers);
            this.panSearchItems.Controls.Add(this.txtSearchSuppliers);
            this.panSearchItems.Location = new System.Drawing.Point(-2, 0);
            this.panSearchItems.Name = "panSearchItems";
            this.panSearchItems.Size = new System.Drawing.Size(757, 75);
            this.panSearchItems.TabIndex = 0;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewAll.Location = new System.Drawing.Point(411, 26);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(98, 30);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnNewSuppliers
            // 
            this.btnNewSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnNewSuppliers.FlatAppearance.BorderSize = 0;
            this.btnNewSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSuppliers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewSuppliers.Location = new System.Drawing.Point(643, 26);
            this.btnNewSuppliers.Name = "btnNewSuppliers";
            this.btnNewSuppliers.Size = new System.Drawing.Size(98, 30);
            this.btnNewSuppliers.TabIndex = 3;
            this.btnNewSuppliers.Text = "New";
            this.btnNewSuppliers.UseVisualStyleBackColor = false;
            this.btnNewSuppliers.Click += new System.EventHandler(this.btnNewSuppliers_Click);
            // 
            // btnSearchSuppliers
            // 
            this.btnSearchSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSearchSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSearchSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSuppliers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchSuppliers.Location = new System.Drawing.Point(293, 26);
            this.btnSearchSuppliers.Name = "btnSearchSuppliers";
            this.btnSearchSuppliers.Size = new System.Drawing.Size(98, 30);
            this.btnSearchSuppliers.TabIndex = 3;
            this.btnSearchSuppliers.Text = "Search";
            this.btnSearchSuppliers.UseVisualStyleBackColor = false;
            this.btnSearchSuppliers.Click += new System.EventHandler(this.btnSearchSuppliers_Click);
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.txtSearchSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSuppliers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchSuppliers.Location = new System.Drawing.Point(23, 24);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(237, 32);
            this.txtSearchSuppliers.TabIndex = 1;
            this.txtSearchSuppliers.Text = "Search Suppliers";
            this.txtSearchSuppliers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearchSuppliers_MouseDown);
            // 
            // lblListOfSuppliers
            // 
            this.lblListOfSuppliers.AutoSize = true;
            this.lblListOfSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.lblListOfSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListOfSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblListOfSuppliers.Location = new System.Drawing.Point(175, 85);
            this.lblListOfSuppliers.Name = "lblListOfSuppliers";
            this.lblListOfSuppliers.Size = new System.Drawing.Size(0, 24);
            this.lblListOfSuppliers.TabIndex = 2;
            // 
            // dgListOfSuppliers
            // 
            this.dgListOfSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListOfSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListOfSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListOfSuppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgListOfSuppliers.Location = new System.Drawing.Point(21, 112);
            this.dgListOfSuppliers.Name = "dgListOfSuppliers";
            this.dgListOfSuppliers.Size = new System.Drawing.Size(718, 436);
            this.dgListOfSuppliers.TabIndex = 1;
            this.dgListOfSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListOfSuppliers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Suppliers";
            // 
            // UC_Suppilers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panSuppliers);
            this.Name = "UC_Suppilers";
            this.Size = new System.Drawing.Size(754, 567);
            this.panSuppliers.ResumeLayout(false);
            this.panSuppliers.PerformLayout();
            this.panSearchItems.ResumeLayout(false);
            this.panSearchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuppliers;
        private System.Windows.Forms.Panel panSearchItems;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnNewSuppliers;
        private System.Windows.Forms.Button btnSearchSuppliers;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Label lblListOfSuppliers;
        private System.Windows.Forms.DataGridView dgListOfSuppliers;
        private System.Windows.Forms.Label label1;
    }
}
