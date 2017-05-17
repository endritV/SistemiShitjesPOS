namespace SistemiShitjesPOS.UI
{
    partial class UC_UpdateEmpoyees
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
            this.btnSubmitEmployees = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxEmployees = new System.Windows.Forms.PictureBox();
            this.cmbRoliId = new System.Windows.Forms.ComboBox();
            this.cmbSektoriId = new System.Windows.Forms.ComboBox();
            this.dtDiteLindja = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNrTelefonit = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtIdEmployees = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitEmployees
            // 
            this.btnSubmitEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmitEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSubmitEmployees.FlatAppearance.BorderSize = 0;
            this.btnSubmitEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmitEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmitEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEmployees.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmitEmployees.Location = new System.Drawing.Point(243, 552);
            this.btnSubmitEmployees.Name = "btnSubmitEmployees";
            this.btnSubmitEmployees.Size = new System.Drawing.Size(117, 30);
            this.btnSubmitEmployees.TabIndex = 24;
            this.btnSubmitEmployees.Text = "Submit";
            this.btnSubmitEmployees.UseVisualStyleBackColor = false;
            this.btnSubmitEmployees.Click += new System.EventHandler(this.btnSubmitEmployees_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(396, 552);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 30);
            this.btnDelete.TabIndex = 25;
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
            this.label2.Location = new System.Drawing.Point(192, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Plot the data for update Employees\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 42;
            this.label1.Text = "Employees";
            // 
            // picBoxEmployees
            // 
            this.picBoxEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBoxEmployees.Location = new System.Drawing.Point(14, 13);
            this.picBoxEmployees.Name = "picBoxEmployees";
            this.picBoxEmployees.Size = new System.Drawing.Size(138, 115);
            this.picBoxEmployees.TabIndex = 39;
            this.picBoxEmployees.TabStop = false;
            // 
            // cmbRoliId
            // 
            this.cmbRoliId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRoliId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.cmbRoliId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoliId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoliId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbRoliId.FormattingEnabled = true;
            this.cmbRoliId.Location = new System.Drawing.Point(479, 266);
            this.cmbRoliId.MaximumSize = new System.Drawing.Size(445, 0);
            this.cmbRoliId.MinimumSize = new System.Drawing.Size(445, 0);
            this.cmbRoliId.Name = "cmbRoliId";
            this.cmbRoliId.Size = new System.Drawing.Size(445, 31);
            this.cmbRoliId.TabIndex = 34;
            this.cmbRoliId.Text = "Roli Id";
            // 
            // cmbSektoriId
            // 
            this.cmbSektoriId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSektoriId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.cmbSektoriId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSektoriId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSektoriId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSektoriId.FormattingEnabled = true;
            this.cmbSektoriId.Location = new System.Drawing.Point(479, 218);
            this.cmbSektoriId.MaximumSize = new System.Drawing.Size(445, 0);
            this.cmbSektoriId.MinimumSize = new System.Drawing.Size(445, 0);
            this.cmbSektoriId.Name = "cmbSektoriId";
            this.cmbSektoriId.Size = new System.Drawing.Size(445, 31);
            this.cmbSektoriId.TabIndex = 33;
            this.cmbSektoriId.Text = "Sektori Id";
            // 
            // dtDiteLindja
            // 
            this.dtDiteLindja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtDiteLindja.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.dtDiteLindja.Location = new System.Drawing.Point(479, 317);
            this.dtDiteLindja.MaximumSize = new System.Drawing.Size(445, 25);
            this.dtDiteLindja.MinimumSize = new System.Drawing.Size(445, 25);
            this.dtDiteLindja.Name = "dtDiteLindja";
            this.dtDiteLindja.Size = new System.Drawing.Size(445, 25);
            this.dtDiteLindja.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Location = new System.Drawing.Point(28, 463);
            this.txtPassword.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtPassword.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(445, 32);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserName.Location = new System.Drawing.Point(28, 416);
            this.txtUserName.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtUserName.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(445, 32);
            this.txtUserName.TabIndex = 37;
            this.txtUserName.Text = "User Name";
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdresa.Location = new System.Drawing.Point(28, 514);
            this.txtAdresa.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtAdresa.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(445, 32);
            this.txtAdresa.TabIndex = 31;
            this.txtAdresa.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.Location = new System.Drawing.Point(28, 364);
            this.txtEmail.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtEmail.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 32);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Text = "Email";
            // 
            // txtNrTelefonit
            // 
            this.txtNrTelefonit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtNrTelefonit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrTelefonit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTelefonit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNrTelefonit.Location = new System.Drawing.Point(28, 317);
            this.txtNrTelefonit.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.Name = "txtNrTelefonit";
            this.txtNrTelefonit.Size = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.TabIndex = 35;
            this.txtNrTelefonit.Text = "Phone Number";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtMbiemri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMbiemri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMbiemri.Location = new System.Drawing.Point(28, 265);
            this.txtMbiemri.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtMbiemri.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(445, 32);
            this.txtMbiemri.TabIndex = 30;
            this.txtMbiemri.Text = "Surname";
            // 
            // txtEmri
            // 
            this.txtEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmri.Location = new System.Drawing.Point(28, 217);
            this.txtEmri.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(445, 32);
            this.txtEmri.TabIndex = 29;
            this.txtEmri.Text = "Name";
            // 
            // txtIdEmployees
            // 
            this.txtIdEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmployees.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdEmployees.Location = new System.Drawing.Point(28, 161);
            this.txtIdEmployees.Name = "txtIdEmployees";
            this.txtIdEmployees.ReadOnly = true;
            this.txtIdEmployees.Size = new System.Drawing.Size(124, 32);
            this.txtIdEmployees.TabIndex = 28;
            this.txtIdEmployees.Text = "Id";
            // 
            // UC_UpdateEmpoyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxEmployees);
            this.Controls.Add(this.cmbRoliId);
            this.Controls.Add(this.cmbSektoriId);
            this.Controls.Add(this.dtDiteLindja);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNrTelefonit);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtIdEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmitEmployees);
            this.Name = "UC_UpdateEmpoyees";
            this.Size = new System.Drawing.Size(754, 567);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitEmployees;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxEmployees;
        private System.Windows.Forms.ComboBox cmbRoliId;
        private System.Windows.Forms.ComboBox cmbSektoriId;
        private System.Windows.Forms.DateTimePicker dtDiteLindja;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNrTelefonit;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtIdEmployees;
    }
}
