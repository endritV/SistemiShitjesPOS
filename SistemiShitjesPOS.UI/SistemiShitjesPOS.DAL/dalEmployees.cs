using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalEmployees
    {
        public static string cs = DataBaseCon.GetConnectionString();

        public static void Insert(Puntori p)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShtoPuntorin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_IdPuntori", p.IdPuntori);
                cmd.Parameters.AddWithValue("@_IdRoli", p.IdRoli);
                cmd.Parameters.AddWithValue("@_IdSektori", p.IdSektori);
                cmd.Parameters.AddWithValue("@_Emri", p.Emri);
                cmd.Parameters.AddWithValue("@_Mbiemri", p.Mbiemri);
                cmd.Parameters.AddWithValue("@_DataLindjes", p.DataLindjes);
                cmd.Parameters.AddWithValue("@_Email", p.Email);
                cmd.Parameters.AddWithValue("@_Adresa", p.Adresa);
                cmd.Parameters.AddWithValue("@_NrTelefonit", p.NrTelefonit);
                cmd.Parameters.AddWithValue("@_UserName", p.UserName);
                cmd.Parameters.AddWithValue("@_Password", p.Passwordi);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
