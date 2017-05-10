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
    public class dalSektori
    {
        static string cs = DataBaseCon.GetConnectionString();

        public static List<Sektori> GetAll()
        {
            List<Sektori> list = new List<Sektori>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqSektoret", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sektori = new Sektori();

                        sektori.EmriSektorit = reader["EmriSektorit"].ToString();
                        sektori.IdSektori = int.Parse(reader["IdSektori"].ToString());

                        list.Add(sektori);
                    }

                }
            }
            return list;
        }
    }
}
