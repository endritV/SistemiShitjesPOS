using SistemiShitjesPOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemiShitjesPOS.EntityLayer;
using SistemiShitjesPOS.BOL;

namespace SistemiShitjesPOS.BOL
{
    public class ArtikulliBOL
    {
        public static List<Artikulli> GetItemByBarkodi(int barkodi)
        {
            List<Artikulli> list = new List<Artikulli>();
            using (SqlConnection con = new SqlConnection(DataBaseCon.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spKerkoArtikullin",con);
                cmd.Parameters.AddWithValue("@_Barkodi", barkodi);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Artikulli artikulli = new Artikulli();
                        artikulli.Barkodi = barkodi;
                        artikulli.IdArtikulli = Int32.Parse(reader["IdArtikulli"].ToString());
                        artikulli.EmriArtikullit = reader["EmriArtikullit"].ToString();
                        artikulli.IsAktiv =  bool.Parse( reader["IsAktiv"].ToString());
                        artikulli.Njesia = reader["IdArtikulli"].ToString();
                        artikulli.Pershkrimi = reader["IdArtikulli"].ToString();
                        

                    }
                }

            }
            return list;


        }
    }
}
