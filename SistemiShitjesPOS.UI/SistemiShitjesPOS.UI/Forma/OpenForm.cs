using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiShitjesPOS.UI
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void OpenForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            LoginForm login = new LoginForm();
            this.Visible = false;
            login.ShowDialog();
            
        }

    }
}
