using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemiShitjesPOS.DAL
{
    public class DataBaseCon
    {
        public static string GetConnectionString()
        {
           return ConfigurationManager.AppSettings["conStr1"].ToString();
        }

    }
}
