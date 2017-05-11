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
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresani);
                cmd.Parameters.AddWithValue("@_NrTelefeoni", k.NrTelefonit);
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static List<Klienti> GetAll()
        {
            List<Klienti> list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqTeGjithKlientet", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var klienti = new Klienti();
                        klienti.IdKlienti = reader["IdKlienti"].ToString();
                        klienti.Emri = reader["Emri"].ToString();
                        klienti.Adresani = reader["Adresa"].ToString();
                        klienti.NrTelefonit = reader["NrTelefonit"].ToString();
                        klienti.IsKlient = bool.Parse(reader["IsKlinet"].ToString());

                        list.Add(klienti);
                    }
                    conn.Close();

                }
            }
            return list;

        }
        public static List<Klienti> GetklientByID(string id)
        {
            var list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spKerkoKlientin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", id);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var klienti = new Klienti();
                        klienti.IdKlienti = id;
                        klienti.Emri = reader["Emri"].ToString();
                        klienti.Adresani = reader["Adresa"].ToString();
                        klienti.NrTelefonit = reader["NrTelefonit"].ToString();
                        klienti.IsKlient = bool.Parse(reader["IsKlinet"].ToString());

                        list.Add(klienti);
                    }

                }
            }
            return list;
        }
        public static List<Klienti> UpdateClient(Klienti k)
        {
            var list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spNdryshoKlientin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", k.IdKlienti);
                cmd.Parameters.AddWithValue("@_Emri", k.Emri);
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresani);
                cmd.Parameters.AddWithValue("@_NrTelefeoni", k.NrTelefonit);
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);

                cmd.CommandType = CommandType.StoredProcedure;

                int o = cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            return list;

        }
        public static List<Klienti> DeleteKlientById(string id)
        {
            var list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spFshijFurnitorin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", id);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var klienti = new Klienti();

                        klienti.IdKlienti = id;
                        list.Add(klienti);
                    }
                }
                return list;
            }
        }
    }
}