namespace SistemiShitjesPOS.UI
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.tblPanMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboards = new System.Windows.Forms.Button();
            this.btnGiftCard = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSectorRole = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tblPanMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanMenu
            // 
            resources.ApplyResources(this.tblPanMenu, "tblPanMenu");
            this.tblPanMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.tblPanMenu.Controls.Add(this.btnLogOut, 0, 10);
            this.tblPanMenu.Controls.Add(this.btnDashboards, 0, 0);
            this.tblPanMenu.Controls.Add(this.btnGiftCard, 0, 9);
            this.tblPanMenu.Controls.Add(this.btnEmployees, 0, 8);
            this.tblPanMenu.Controls.Add(this.btnExpenses, 0, 7);
            this.tblPanMenu.Controls.Add(this.btnSales, 0, 6);
            this.tblPanMenu.Controls.Add(this.btnCustomers, 0, 1);
            this.tblPanMenu.Controls.Add(this.btnItems, 0, 2);
            this.tblPanMenu.Controls.Add(this.btnReports, 0, 5);
            this.tblPanMenu.Controls.Add(this.btnSectorRole, 0, 3);
            this.tblPanMenu.Controls.Add(this.btnSuppliers, 0, 4);
            this.tblPanMenu.Name = "tblPanMenu";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panMenu
            // 
            resources.ApplyResources(this.panMenu, "panMenu");
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panMenu.Controls.Add(this.btnSettings);
            this.panMenu.Controls.Add(this.tblPanMenu);
            this.panMenu.Controls.Add(this.btnMenu);
            this.panMenu.Name = "panMenu";
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.BackgroundImage = global::SistemiShitjesPOS.UI.Properties.Resources.ionicons_2_0_1_android_settings_50_15_a7bccd_none;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogOut
            // 
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnLogOut.Image = global::SistemiShitjesPOS.UI.Properties.Resources.ligature_symbols_2_11_0_logout_30_0_ff0000_none;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashboards
            // 
            resources.ApplyResources(this.btnDashboards, "btnDashboards");
            this.btnDashboards.FlatAppearance.BorderSize = 0;
            this.btnDashboards.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnDashboards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnDashboards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnDashboards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDashboards.Image = global::SistemiShitjesPOS.UI.Properties.Resources.icomoon_free_2014_12_23_stats_bars_25_0_647d91_none;
            this.btnDashboards.Name = "btnDashboards";
            this.btnDashboards.UseVisualStyleBackColor = true;
            this.btnDashboards.Click += new System.EventHandler(this.btnDashboards_Click);
            // 
            // btnGiftCard
            // 
            resources.ApplyResources(this.btnGiftCard, "btnGiftCard");
            this.btnGiftCard.FlatAppearance.BorderSize = 0;
            this.btnGiftCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnGiftCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnGiftCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnGiftCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnGiftCard.Image = global::SistemiShitjesPOS.UI.Properties.Resources.font_awesome_4_7_0_address_card_25_0_647d91_none;
            this.btnGiftCard.Name = "btnGiftCard";
            this.btnGiftCard.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            resources.ApplyResources(this.btnEmployees, "btnEmployees");
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnEmployees.Image = global::SistemiShitjesPOS.UI.Properties.Resources.ligature_symbols_2_11_0_human_25_0_647d91_none;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnExpenses
            // 
            resources.ApplyResources(this.btnExpenses, "btnExpenses");
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnExpenses.Image = global::SistemiShitjesPOS.UI.Properties.Resources.font_awesome_4_7_0_euro_25_0_647d91_none;
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            resources.ApplyResources(this.btnSales, "btnSales");
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSales.Image = global::SistemiShitjesPOS.UI.Properties.Resources.foundation_icon_fonts_2015_02_16_burst_sale_25_0_647d91_none;
            this.btnSales.Name = "btnSales";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            resources.ApplyResources(this.btnCustomers, "btnCustomers");
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnCustomers.Image = global::SistemiShitjesPOS.UI.Properties.Resources.ionicons_2_0_1_ios_people_25_0_647d91_none;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnItems
            // 
            resources.ApplyResources(this.btnItems, "btnItems");
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnItems.Image = global::SistemiShitjesPOS.UI.Properties.Resources.foundation_icon_fonts_2015_02_16_shopping_bag_25_0_647d91_none;
            this.btnItems.Name = "btnItems";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnReports
            // 
            resources.ApplyResources(this.btnReports, "btnReports");
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnReports.Image = global::SistemiShitjesPOS.UI.Properties.Resources.foundation_icon_fonts_2015_02_16_clipboard_notes_25_0_647d91_none;
            this.btnReports.Name = "btnReports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSectorRole
            // 
            resources.ApplyResources(this.btnSectorRole, "btnSectorRole");
            this.btnSectorRole.FlatAppearance.BorderSize = 0;
            this.btnSectorRole.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSectorRole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSectorRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSectorRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSectorRole.Image = global::SistemiShitjesPOS.UI.Properties.Resources.icomoon_free_2014_12_23_price_tags_25_0_647d91_none;
            this.btnSectorRole.Name = "btnSectorRole";
            this.btnSectorRole.UseVisualStyleBackColor = true;
            this.btnSectorRole.Click += new System.EventHandler(this.btnSectoreRole_Click);
            // 
            // btnSuppliers
            // 
            resources.ApplyResources(this.btnSuppliers, "btnSuppliers");
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnSuppliers.Image = global::SistemiShitjesPOS.UI.Properties.Resources.icomoon_free_2014_12_23_truck_25_0_647d91_none;
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.Image = global::SistemiShitjesPOS.UI.Properties.Resources.icomoon_free_2014_12_23_menu_25_25_a7bccd_none;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // DashBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.tblPanMenu.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDashboards;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSectorRole;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnGiftCard;
        private System.Windows.Forms.TableLayoutPanel tblPanMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMenu;
        ////private UC_Dashboards uC_Dashboards1;
    }
}