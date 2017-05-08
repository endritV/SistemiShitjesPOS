using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemiShitjesPOS.DAL
{
    public static class DataBaseCon
    {
        public static readonly string Connection = ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;
        public static string GetConString()
        {

            return ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;

        }   

    }

    
}
