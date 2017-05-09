using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalItems
    {

        static string cs = DataBaseCon.GetConnectionString();


        public static void Insert(Artikulli a)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShtoArtikullin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_EmriArtikullit", a.EmriArtikullit);
                cmd.Parameters.AddWithValue("@_Barkodi", a.Barkodi);
                cmd.Parameters.AddWithValue("@_Njesia", a.Njesia);
                cmd.Parameters.AddWithValue("@_Pershkrimi", a.Pershkrimi);
                cmd.Parameters.AddWithValue("@_IsAktvi", a.IsAktiv);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Artikulli> GetAll()
        {
            List<Artikulli> list = new List<Artikulli>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqTeGjithaArtikujtv2", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var artikulli = new Artikulli();
 
                        artikulli.Pershkrimi = reader["Pershkrimi"].ToString();
                        artikulli.IsAktiv = bool.Parse(reader["IsAktive"].ToString());
                        artikulli.IdArtikulli = int.Parse(reader["IdArtikulli"].ToString());
                        artikulli.EmriArtikullit = reader["EmriArtikullit"].ToString();
                        artikulli.Barkodi = int.Parse(reader["Barkodi"].ToString());



                        list.Add(artikulli);
                    }

                }
            }
            return list;
        }
    }
}
