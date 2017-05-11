using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalRoli
    {

        static string cs = DataBaseCon.GetConnectionString();
        public static void Insert(Roli r)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("spShtoRolin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_IdRoli", r.IdRoli);
                cmd.Parameters.AddWithValue("@_Emri", r.Emri);
                cmd.Parameters.AddWithValue("@_IsActive", r.IsActive);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
