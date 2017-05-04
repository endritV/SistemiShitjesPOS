using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemiShitjesPOS.DAL
{
    class DataBaseCon
    {
        public SqlConnection con;
        public void Connection()
        {

            con = new SqlConnection("Data Source=SQL6001.SmarterASP.NET;Initial Catalog=DB_A1F690_Kisamava;User Id=DB_A1F690_Kisamava_admin;Password=fuckem123;");

        }
        
    }
}
