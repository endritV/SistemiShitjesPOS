using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BusinessLayer;
using System.Data.SqlClient;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_SektoriRoli : UserControl
    {
        public UC_SektoriRoli()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            blRoli.InsertRoli(new Roli(txtIdRoli.Text, txtEmriRolit.Text, rdbAktiv.Checked));
        }

        private void btnSubmitSektori_Click(object sender, EventArgs e)
        {
            blSektori.InsertSector(new Sektori(int.Parse(txtSektoriId.Text), txtEmriSektorit.Text));
        }
    }
}
