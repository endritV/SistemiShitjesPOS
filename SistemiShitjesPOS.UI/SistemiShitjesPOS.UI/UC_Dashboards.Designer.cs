namespace SistemiShitjesPOS.UI
{
    partial class UC_Dashboards
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchDashboards = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(155)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.txtSearchDashboards);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 50);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchDashboards
            // 
            this.txtSearchDashboards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchDashboards.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDashboards.Location = new System.Drawing.Point(6, 8);
            this.txtSearchDashboards.Name = "txtSearchDashboards";
            this.txtSearchDashboards.Size = new System.Drawing.Size(390, 31);
            this.txtSearchDashboards.TabIndex = 0;
            // 
            // UC_Dashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.panel1);
            this.Name = "UC_Dashboards";
            this.Size = new System.Drawing.Size(754, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchDashboards;
    }
}
