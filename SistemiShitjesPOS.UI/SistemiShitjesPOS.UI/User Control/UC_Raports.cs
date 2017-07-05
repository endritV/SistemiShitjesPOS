using SistemiShitjesPOS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class UC_Raports : UserControl
    {
        public UC_Raports()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UC_Raports_Load(object sender, EventArgs e)
        {

        }

        private void btnGetRaports_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(DataBaseCon.GetConnectionString());
            SqlDataAdapter da = new SqlDataAdapter("Select * from FaturaDetajet where data between '"+dtPickerFrom.Value.ToString() + "'and'"+dtPickerTo.Value.ToString()+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgRaports.DataSource = dt;

            double t2=0;
            for (int i = 0; i < dgRaports.Rows.Count; i++)
            {
                t2 += Convert.ToDouble(dgRaports.Rows[i].Cells[3].Value);
            }
            lblAllAmount.Text = t2.ToString();
        }

        private void lblAmountText_Click(object sender, EventArgs e)
        {

        }

        
    }
}
