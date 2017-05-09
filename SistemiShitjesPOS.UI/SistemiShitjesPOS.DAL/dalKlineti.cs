using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace SistemiShitjesPOS.DataAccessLayer
{

    public class dalKlineti
    {
        static string cs = DataBaseCon.GetConnectionString();

        public static void Insert(Klienti k)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShtoKlient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_IdKlienti", k.IdKlienti);
                cmd.Parameters.AddWithValue("@_Emri", k.Emri);
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresa);
                cmd.Parameters.AddWithValue("@_NrTelefeoni", k.NrTelefonit);
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);
                cmd.ExecuteNonQuery();
            }
        }
    }
}