using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;

namespace SistemiShitjesPOS.UI
{
    public partial class NewItems : MetroFramework.Forms.MetroForm
    {
        public NewItems()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                blItems.InsertNewItems(new Artikulli(txtEmri.Text, int.Parse(txtBarkodi.Text), txtPershkrimi.Text, cmbCategory.Text));
            }
            catch (Exception)
            {

                MetroFramework.MetroMessageBox.Show(this, "Please plot your data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MetroFramework.MetroMessageBox.Show(this, "Items insert with successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
