using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Security.Cryptography;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalLogin
    {
        static string cs = DataBaseCon.GetConnectionString();


        public static string AdminVerification(string user, string pw)
        {
            string output = "";

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string query = "Select * from Puntori where UserName='" + user + "' and Passwordi='" + DataBaseCon.GetHash(pw) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                output = cmd.ExecuteScalar().ToString();

            }
            return output;
        }
    }
}
