namespace SistemiShitjesPOS.UI
{
    partial class UC_Raports
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
            this.dgRaports = new System.Windows.Forms.DataGridView();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnGetRaports = new System.Windows.Forms.Button();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.lblAllAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRaports
            // 
            this.dgRaports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaports.Location = new System.Drawing.Point(3, 162);
            this.dgRaports.Name = "dgRaports";
            this.dgRaports.Size = new System.Drawing.Size(748, 348);
            this.dgRaports.TabIndex = 0;
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Location = new System.Drawing.Point(161, 104);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(202, 20);
            this.dtPickerFrom.TabIndex = 1;
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Location = new System.Drawing.Point(398, 104);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(213, 20);
            this.dtPickerTo.TabIndex = 2;
            // 
            // btnGetRaports
            // 
            this.btnGetRaports.Location = new System.Drawing.Point(636, 516);
            this.btnGetRaports.Name = "btnGetRaports";
            this.btnGetRaports.Size = new System.Drawing.Size(96, 48);
            this.btnGetRaports.TabIndex = 3;
            this.btnGetRaports.Text = "Get Raports";
            this.btnGetRaports.UseVisualStyleBackColor = true;
            this.btnGetRaports.Click += new System.EventHandler(this.btnGetRaports_Click);
            // 
            // lblAmountText
            // 
            this.lblAmountText.AutoSize = true;
            this.lblAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountText.Location = new System.Drawing.Point(351, 526);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(124, 24);
            this.lblAmountText.TabIndex = 4;
            this.lblAmountText.Text = "All Amount :";
            this.lblAmountText.Click += new System.EventHandler(this.lblAmountText_Click);
            // 
            // lblAllAmount
            // 
            this.lblAllAmount.AutoSize = true;
            this.lblAllAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllAmount.Location = new System.Drawing.Point(499, 526);
            this.lblAllAmount.Name = "lblAllAmount";
            this.lblAllAmount.Size = new System.Drawing.Size(0, 24);
            this.lblAllAmount.TabIndex = 5;
            // 
            // UC_Raports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.lblAllAmount);
            this.Controls.Add(this.lblAmountText);
            this.Controls.Add(this.btnGetRaports);
            this.Controls.Add(this.dtPickerTo);
            this.Controls.Add(this.dtPickerFrom);
            this.Controls.Add(this.dgRaports);
            this.Name = "UC_Raports";
            this.Size = new System.Drawing.Size(754, 567);
            this.Load += new System.EventHandler(this.UC_Raports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRaports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRaports;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.Button btnGetRaports;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.Label lblAllAmount;
    }
}
