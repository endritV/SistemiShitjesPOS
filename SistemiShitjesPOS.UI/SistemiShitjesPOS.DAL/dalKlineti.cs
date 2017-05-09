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
            }
        }
        public static List<Klienti> GetAll()
        {
            var list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqTeGjithKlientet", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Klienti klienti = new Klienti();
                        klienti.IdKlienti = reader["IdKlienti"].ToString();
                        klienti.Emri = reader["Emri"].ToString();
                        //klienti.Adresani = reader["Adresa"].ToString();
                        klienti.NrTelefonit = reader["NrTelefonit"].ToString();
                        klienti.IsKlient = bool.Parse(reader["IsKlinet"].ToString());

                        list.Add(klienti);


                    }

                }
            }
            return list;
        }
        public static List<Klienti> GetKlientById(string klientId)
        {
            var list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spKerkoKlientin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", klientId);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Klienti klienti = new Klienti();
                        klienti.IdKlienti = klientId;

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
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);
                cmd.Parameters.AddWithValue("@_Emri", k.Emri);
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresani);
                cmd.Parameters.AddWithValue("@_NrTelefeoni", k.NrTelefonit);

                cmd.CommandType = CommandType.StoredProcedure;

                int o = cmd.ExecuteNonQuery();


            }



            
            return list;
        }
    }
}


//public static void Update(Klienti klienti)
//{
//    foreach (Klienti oldKlient in _listOfKlient)
//    {
//        if (klienti.NrBiznesit == oldKlient.NrBiznesit)
//        {
//            oldKlient.Emri = klienti.Emri;
//        }
//    }
//}

//public static void Remove(string nrBiznesit)
//{
//    var cmp = GetSingleKlinet(nrBiznesit);
//    _listOfKlient.Remove(cmp);
//}

//public static Klienti GetSingleKlinet(string nrBiznesit)
//{
//    foreach (Klienti klienti in _listOfKlient)
//    {
//        if (klienti.NrBiznesit == nrBiznesit)
//            return klienti;
//    }
//    return null;
//}
