using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public static class DataBaseConection
    {
        public static string GetConnection()
        {
            return ConfigurationManager.AppSettings["conStr1"].ToString();

        }
    }
}
