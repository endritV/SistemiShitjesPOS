namespace SistemiShitjesPOS.UI
{
    partial class UC_Items
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
            this.panSearchItems = new System.Windows.Forms.Panel();
            this.btnNewItems = new System.Windows.Forms.Button();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.panNew = new System.Windows.Forms.Panel();
            this.panSearchItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSearchItems
            // 
            this.panSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panSearchItems.Controls.Add(this.btnNewItems);
            this.panSearchItems.Controls.Add(this.btnSearchItems);
            this.panSearchItems.Controls.Add(this.cmbCategory);
            this.panSearchItems.Controls.Add(this.txtSearchItems);
            this.panSearchItems.Location = new System.Drawing.Point(-3, 2);
            this.panSearchItems.Name = "panSearchItems";
            this.panSearchItems.Size = new System.Drawing.Size(757, 75);
            this.panSearchItems.TabIndex = 0;
            // 
            // btnNewItems
            // 
            this.btnNewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnNewItems.FlatAppearance.BorderSize = 0;
            this.btnNewItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItems.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewItems.Location = new System.Drawing.Point(644, 28);
            this.btnNewItems.Name = "btnNewItems";
            this.btnNewItems.Size = new System.Drawing.Size(98, 30);
            this.btnNewItems.TabIndex = 3;
            this.btnNewItems.Text = "New";
            this.btnNewItems.UseVisualStyleBackColor = false;
            this.btnNewItems.Click += new System.EventHandler(this.btnNewItems_Click);
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSearchItems.FlatAppearance.BorderSize = 0;
            this.btnSearchItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchItems.Location = new System.Drawing.Point(412, 27);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(98, 30);
            this.btnSearchItems.TabIndex = 3;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(227, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(157, 31);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Text = "Category";
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.txtSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchItems.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchItems.Location = new System.Drawing.Point(20, 26);
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(182, 32);
            this.txtSearchItems.TabIndex = 1;
            this.txtSearchItems.Text = "Search Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Items";
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.AutoSize = true;
            this.lblListOfItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.lblListOfItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListOfItems.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblListOfItems.Location = new System.Drawing.Point(127, 86);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(0, 23);
            this.lblListOfItems.TabIndex = 2;
            // 
            // panNew
            // 
            this.panNew.Controls.Add(this.panSearchItems);
            this.panNew.Controls.Add(this.lblListOfItems);
            this.panNew.Controls.Add(this.dataGridView1);
            this.panNew.Controls.Add(this.label1);
            this.panNew.Location = new System.Drawing.Point(0, -2);
            this.panNew.Name = "panNew";
            this.panNew.Size = new System.Drawing.Size(754, 541);
            this.panNew.TabIndex = 3;
            // 
            // UC_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.panNew);
            this.Name = "UC_Items";
            this.Size = new System.Drawing.Size(754, 539);
            this.panSearchItems.ResumeLayout(false);
            this.panSearchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panNew.ResumeLayout(false);
            this.panNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSearchItems;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.Button btnNewItems;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListOfItems;
        private System.Windows.Forms.Panel panNew;
    }
}
