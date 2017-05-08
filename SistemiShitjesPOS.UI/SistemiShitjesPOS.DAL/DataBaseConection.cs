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
        public static readonly string Connection = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    }
}
