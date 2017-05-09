namespace SistemiShitjesPOS.UI
{
    partial class UC_Customers
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
            this.panCustomers = new System.Windows.Forms.Panel();
            this.panSearchItems = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnNewCustomers = new System.Windows.Forms.Button();
            this.btnSearchCustomers = new System.Windows.Forms.Button();
            this.txtSearchCustomers = new System.Windows.Forms.TextBox();
            this.lblListOfCustomers = new System.Windows.Forms.Label();
            this.dgListOfCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panCustomers.SuspendLayout();
            this.panSearchItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panCustomers
            // 
            this.panCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCustomers.Controls.Add(this.panSearchItems);
            this.panCustomers.Controls.Add(this.lblListOfCustomers);
            this.panCustomers.Controls.Add(this.dgListOfCustomers);
            this.panCustomers.Controls.Add(this.label1);
            this.panCustomers.Location = new System.Drawing.Point(0, 0);
            this.panCustomers.Name = "panCustomers";
            this.panCustomers.Size = new System.Drawing.Size(754, 567);
            this.panCustomers.TabIndex = 4;
            // 
            // panSearchItems
            // 
            this.panSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panSearchItems.Controls.Add(this.btnViewAll);
            this.panSearchItems.Controls.Add(this.btnNewCustomers);
            this.panSearchItems.Controls.Add(this.btnSearchCustomers);
            this.panSearchItems.Controls.Add(this.txtSearchCustomers);
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
            // btnNewCustomers
            // 
            this.btnNewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnNewCustomers.FlatAppearance.BorderSize = 0;
            this.btnNewCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewCustomers.Location = new System.Drawing.Point(643, 26);
            this.btnNewCustomers.Name = "btnNewCustomers";
            this.btnNewCustomers.Size = new System.Drawing.Size(98, 30);
            this.btnNewCustomers.TabIndex = 3;
            this.btnNewCustomers.Text = "New";
            this.btnNewCustomers.UseVisualStyleBackColor = false;
            this.btnNewCustomers.Click += new System.EventHandler(this.btnNewCustomers_Click);
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSearchCustomers.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchCustomers.Location = new System.Drawing.Point(292, 26);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(98, 30);
            this.btnSearchCustomers.TabIndex = 3;
            this.btnSearchCustomers.Text = "Search";
            this.btnSearchCustomers.UseVisualStyleBackColor = false;
            this.btnSearchCustomers.Click += new System.EventHandler(this.btnSearchCustomers_Click);
            // 
            // txtSearchCustomers
            // 
            this.txtSearchCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.txtSearchCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCustomers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchCustomers.Location = new System.Drawing.Point(23, 24);
            this.txtSearchCustomers.Name = "txtSearchCustomers";
            this.txtSearchCustomers.Size = new System.Drawing.Size(237, 32);
            this.txtSearchCustomers.TabIndex = 1;
            this.txtSearchCustomers.Text = "Search Customers";
            this.txtSearchCustomers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearchCustomers_MouseDown);
            // 
            // lblListOfCustomers
            // 
            this.lblListOfCustomers.AutoSize = true;
            this.lblListOfCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.lblListOfCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblListOfCustomers.Location = new System.Drawing.Point(175, 85);
            this.lblListOfCustomers.Name = "lblListOfCustomers";
            this.lblListOfCustomers.Size = new System.Drawing.Size(0, 24);
            this.lblListOfCustomers.TabIndex = 2;
            // 
            // dgListOfCustomers
            // 
            this.dgListOfCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListOfCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListOfCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListOfCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgListOfCustomers.Location = new System.Drawing.Point(21, 112);
            this.dgListOfCustomers.Name = "dgListOfCustomers";
            this.dgListOfCustomers.Size = new System.Drawing.Size(718, 436);
            this.dgListOfCustomers.TabIndex = 1;
            this.dgListOfCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListOfCustomers_CellContentClick);
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
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Customers";
            // 
            // UC_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panCustomers);
            this.Name = "UC_Customers";
            this.Size = new System.Drawing.Size(754, 567);
            this.panCustomers.ResumeLayout(false);
            this.panCustomers.PerformLayout();
            this.panSearchItems.ResumeLayout(false);
            this.panSearchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListOfCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCustomers;
        private System.Windows.Forms.Panel panSearchItems;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnNewCustomers;
        private System.Windows.Forms.Button btnSearchCustomers;
        private System.Windows.Forms.TextBox txtSearchCustomers;
        private System.Windows.Forms.Label lblListOfCustomers;
        private System.Windows.Forms.DataGridView dgListOfCustomers;
        private System.Windows.Forms.Label label1;
    }
}
