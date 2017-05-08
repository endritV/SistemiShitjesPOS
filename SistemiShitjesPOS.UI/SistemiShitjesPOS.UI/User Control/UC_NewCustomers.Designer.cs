namespace SistemiShitjesPOS.UI
{
    partial class UC_NewCustomers
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
            this.txtNrTelefonit = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtIdEmployees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNrTelefonit
            // 
            this.txtNrTelefonit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtNrTelefonit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrTelefonit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTelefonit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNrTelefonit.Location = new System.Drawing.Point(62, 311);
            this.txtNrTelefonit.Name = "txtNrTelefonit";
            this.txtNrTelefonit.ReadOnly = true;
            this.txtNrTelefonit.Size = new System.Drawing.Size(182, 32);
            this.txtNrTelefonit.TabIndex = 21;
            this.txtNrTelefonit.Text = "Phone Number";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtMbiemri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMbiemri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMbiemri.Location = new System.Drawing.Point(62, 259);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.ReadOnly = true;
            this.txtMbiemri.Size = new System.Drawing.Size(182, 32);
            this.txtMbiemri.TabIndex = 20;
            this.txtMbiemri.Text = "Surname";
            // 
            // txtEmri
            // 
            this.txtEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmri.Location = new System.Drawing.Point(62, 211);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.ReadOnly = true;
            this.txtEmri.Size = new System.Drawing.Size(182, 32);
            this.txtEmri.TabIndex = 19;
            this.txtEmri.Text = "Name";
            // 
            // txtIdEmployees
            // 
            this.txtIdEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdEmployees.Location = new System.Drawing.Point(62, 161);
            this.txtIdEmployees.Name = "txtIdEmployees";
            this.txtIdEmployees.ReadOnly = true;
            this.txtIdEmployees.Size = new System.Drawing.Size(182, 32);
            this.txtIdEmployees.TabIndex = 18;
            this.txtIdEmployees.Text = "Employees Id";
            // 
            // UC_NewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.txtNrTelefonit);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtIdEmployees);
            this.Name = "UC_NewCustomers";
            this.Size = new System.Drawing.Size(754, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNrTelefonit;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtIdEmployees;
    }
}
