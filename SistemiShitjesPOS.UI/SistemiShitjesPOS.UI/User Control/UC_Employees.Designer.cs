namespace SistemiShitjesPOS.UI
{
    partial class UC_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Employees));
            this.panSearchItems = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnNewEmployees = new System.Windows.Forms.Button();
            this.btnSearchEmployees = new System.Windows.Forms.Button();
            this.txtSearchEmployees = new System.Windows.Forms.TextBox();
            this.lblListOfEmployees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panEmployees = new System.Windows.Forms.Panel();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.panSearchItems.SuspendLayout();
            this.panEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearchItems
            // 
            resources.ApplyResources(this.panSearchItems, "panSearchItems");
            this.panSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panSearchItems.Controls.Add(this.btnViewAll);
            this.panSearchItems.Controls.Add(this.btnNewEmployees);
            this.panSearchItems.Controls.Add(this.btnSearchEmployees);
            this.panSearchItems.Controls.Add(this.txtSearchEmployees);
            this.panSearchItems.Name = "panSearchItems";
            // 
            // btnViewAll
            // 
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnNewEmployees
            // 
            resources.ApplyResources(this.btnNewEmployees, "btnNewEmployees");
            this.btnNewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnNewEmployees.FlatAppearance.BorderSize = 0;
            this.btnNewEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNewEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewEmployees.Name = "btnNewEmployees";
            this.btnNewEmployees.UseVisualStyleBackColor = false;
            this.btnNewEmployees.Click += new System.EventHandler(this.btnNewEmployees_Click);
            // 
            // btnSearchEmployees
            // 
            resources.ApplyResources(this.btnSearchEmployees, "btnSearchEmployees");
            this.btnSearchEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSearchEmployees.FlatAppearance.BorderSize = 0;
            this.btnSearchEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSearchEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchEmployees.Name = "btnSearchEmployees";
            this.btnSearchEmployees.UseVisualStyleBackColor = false;
            this.btnSearchEmployees.Click += new System.EventHandler(this.btnSearchEmployees_Click);
            // 
            // txtSearchEmployees
            // 
            resources.ApplyResources(this.txtSearchEmployees, "txtSearchEmployees");
            this.txtSearchEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.txtSearchEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchEmployees.Name = "txtSearchEmployees";
            this.txtSearchEmployees.TextChanged += new System.EventHandler(this.txtSearchEmployees_TextChanged);
            this.txtSearchEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearchEmployees_MouseDown);
            // 
            // lblListOfEmployees
            // 
            resources.ApplyResources(this.lblListOfEmployees, "lblListOfEmployees");
            this.lblListOfEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.lblListOfEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListOfEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblListOfEmployees.Name = "lblListOfEmployees";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.label1.Name = "label1";
            // 
            // panEmployees
            // 
            resources.ApplyResources(this.panEmployees, "panEmployees");
            this.panEmployees.Controls.Add(this.dgEmployees);
            this.panEmployees.Controls.Add(this.lblListOfEmployees);
            this.panEmployees.Controls.Add(this.panSearchItems);
            this.panEmployees.Controls.Add(this.label1);
            this.panEmployees.Name = "panEmployees";
            // 
            // dgEmployees
            // 
            resources.ApplyResources(this.dgEmployees, "dgEmployees");
            this.dgEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellDoubleClick);
            // 
            // UC_Employees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.panEmployees);
            this.Name = "UC_Employees";
            this.panSearchItems.ResumeLayout(false);
            this.panSearchItems.PerformLayout();
            this.panEmployees.ResumeLayout(false);
            this.panEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSearchItems;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnNewEmployees;
        private System.Windows.Forms.Button btnSearchEmployees;
        private System.Windows.Forms.TextBox txtSearchEmployees;
        private System.Windows.Forms.Label lblListOfEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panEmployees;
        private System.Windows.Forms.DataGridView dgEmployees;
    }
}
