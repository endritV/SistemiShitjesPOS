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
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtIdKlient = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdbJoKlient = new System.Windows.Forms.RadioButton();
            this.rdbKlient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNrTelefonit
            // 
            this.txtNrTelefonit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNrTelefonit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtNrTelefonit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNrTelefonit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTelefonit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNrTelefonit.Location = new System.Drawing.Point(165, 383);
            this.txtNrTelefonit.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.Name = "txtNrTelefonit";
            this.txtNrTelefonit.Size = new System.Drawing.Size(445, 32);
            this.txtNrTelefonit.TabIndex = 21;
            this.txtNrTelefonit.Text = "Phone Number";
            this.txtNrTelefonit.TextChanged += new System.EventHandler(this.txtNrTelefonit_TextChanged);
            this.txtNrTelefonit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNrTelefonit_MouseDown);
            // 
            // txtEmri
            // 
            this.txtEmri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmri.Location = new System.Drawing.Point(165, 271);
            this.txtEmri.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(445, 32);
            this.txtEmri.TabIndex = 19;
            this.txtEmri.Text = "Name";
            this.txtEmri.TextChanged += new System.EventHandler(this.txtEmri_TextChanged);
            this.txtEmri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEmri_MouseDown);
            // 
            // txtIdKlient
            // 
            this.txtIdKlient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdKlient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtIdKlient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdKlient.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKlient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdKlient.Location = new System.Drawing.Point(165, 213);
            this.txtIdKlient.MaximumSize = new System.Drawing.Size(122, 32);
            this.txtIdKlient.Name = "txtIdKlient";
            this.txtIdKlient.ReadOnly = true;
            this.txtIdKlient.Size = new System.Drawing.Size(122, 32);
            this.txtIdKlient.TabIndex = 18;
            this.txtIdKlient.Text = "ID";
            this.txtIdKlient.TextChanged += new System.EventHandler(this.txtIdKlient_TextChanged);
            this.txtIdKlient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtIdKlient_MouseDown);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdresa.Location = new System.Drawing.Point(165, 325);
            this.txtAdresa.MaximumSize = new System.Drawing.Size(445, 32);
            this.txtAdresa.MinimumSize = new System.Drawing.Size(445, 32);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(445, 32);
            this.txtAdresa.TabIndex = 18;
            this.txtAdresa.Text = "Address";
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            this.txtAdresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtAdresa_MouseDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmit.Location = new System.Drawing.Point(328, 496);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 30);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdbJoKlient
            // 
            this.rdbJoKlient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbJoKlient.AutoSize = true;
            this.rdbJoKlient.BackColor = System.Drawing.Color.Transparent;
            this.rdbJoKlient.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbJoKlient.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbJoKlient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbJoKlient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbJoKlient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJoKlient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbJoKlient.Location = new System.Drawing.Point(402, 447);
            this.rdbJoKlient.Name = "rdbJoKlient";
            this.rdbJoKlient.Size = new System.Drawing.Size(79, 24);
            this.rdbJoKlient.TabIndex = 23;
            this.rdbJoKlient.TabStop = true;
            this.rdbJoKlient.Text = "Jo Klient";
            this.rdbJoKlient.UseVisualStyleBackColor = false;
            this.rdbJoKlient.CheckedChanged += new System.EventHandler(this.rdbJoKlient_CheckedChanged);
            // 
            // rdbKlient
            // 
            this.rdbKlient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbKlient.AutoSize = true;
            this.rdbKlient.BackColor = System.Drawing.Color.Transparent;
            this.rdbKlient.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.rdbKlient.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orange;
            this.rdbKlient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.rdbKlient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rdbKlient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKlient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbKlient.Location = new System.Drawing.Point(299, 447);
            this.rdbKlient.Name = "rdbKlient";
            this.rdbKlient.Size = new System.Drawing.Size(60, 24);
            this.rdbKlient.TabIndex = 24;
            this.rdbKlient.TabStop = true;
            this.rdbKlient.Text = "Klient";
            this.rdbKlient.UseVisualStyleBackColor = false;
            this.rdbKlient.CheckedChanged += new System.EventHandler(this.rdbKlient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(292, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(161, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Plot the data for add a new Customers";
            // 
            // UC_NewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbJoKlient);
            this.Controls.Add(this.rdbKlient);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNrTelefonit);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtIdKlient);
            this.Name = "UC_NewCustomers";
            this.Size = new System.Drawing.Size(754, 567);
            this.Load += new System.EventHandler(this.UC_NewCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNrTelefonit;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtIdKlient;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdbJoKlient;
        private System.Windows.Forms.RadioButton rdbKlient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
