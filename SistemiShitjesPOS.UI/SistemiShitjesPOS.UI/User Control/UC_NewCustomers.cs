using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_NewCustomers : UserControl
    {
        public UC_NewCustomers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            blKlienti.InsertNewClietn(new Klienti(txtIdKlient.Text,txtEmri.Text,txtAdresa.Text,txtNrTelefonit.Text,rdbKlient.Checked));

        }
          

    }
}
