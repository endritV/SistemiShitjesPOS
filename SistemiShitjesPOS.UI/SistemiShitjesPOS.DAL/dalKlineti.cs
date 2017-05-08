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
        static readonly string cs = DataBaseCon.GetConnectionString();

        public static List<Klienti> GetKlietnById(string klinetId)
        {
            List<Klienti> list = new List<Klienti>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spKerkoKlientin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", klinetId);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    Klienti klienti = new Klienti();
                    klienti.IdKlienti = klinetId;
                    klienti.Emri = reader["Name"].ToString();
                    klienti.IsKlient = bool.Parse(reader["IsKlient"].ToString());
                    klienti.NrTelefonit = reader["Phone Number"].ToString();
                    klienti.Pikat = Int32.Parse( reader["Pikat"].ToString());

                }
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
