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

        public static List<Puntori> GetAll()
        {
            List<Puntori> list = new List<Puntori>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqTeGjithePuntoret", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var puntori = new Puntori();
                        puntori.IdRoli = int.Parse(reader["IdRoli"].ToString());
                        puntori.UserName = reader["UserName"].ToString();
                        puntori.Passwordi = reader["Passwordi"].ToString();
                        puntori.Email = reader["Email"].ToString();
                        puntori.NrTelefonit = reader["NrTelefonit"].ToString();
                        puntori.Adresa = reader["Adresa"].ToString();
                        puntori.DataLindjes = DateTime.Parse(reader["DataLindjes"].ToString());
                        puntori.Mbiemri = reader["Mbimeri"].ToString();
                        puntori.Emri = reader["Emri"].ToString();
                        puntori.IdSektori = int.Parse(reader["IdSektori"].ToString());
                        puntori.IdPuntori = reader["IdPuntori"].ToString();

                        list.Add(puntori);
                    }

                }
            }
            return list;
        }
        public static List<Puntori> GetEmplyoeeByiD(string id)
        {
            var list = new List<Puntori>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spKerkoPuntorin", conn);
                cmd.Parameters.AddWithValue("@_IdPuntori", id);
                
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var puntori = new Puntori();
                        puntori.IdPuntori = id;
                        puntori.IdSektori = int.Parse(reader["IdSektori"].ToString());
                        puntori.Emri = reader["Emri"].ToString();
                        puntori.Mbiemri = reader["Mbimeri"].ToString();
                        puntori.IdRoli = int.Parse(reader["IdRoli"].ToString());
                        puntori.UserName = reader["UserName"].ToString();
                        puntori.Passwordi = reader["Passwordi"].ToString();
                        puntori.Email = reader["Email"].ToString();
                        puntori.NrTelefonit = reader["NrTelefonit"].ToString();
                        puntori.Adresa = reader["Adresa"].ToString();
                        puntori.DataLindjes = DateTime.Parse(reader["DataLindjes"].ToString());
                        
                       
                       
                        
                        list.Add(puntori);
                    }

                }
            }
            return list;
        }
        public static List<Puntori> UpdateEmployee(Puntori p)
        {
            var list = new List<Puntori>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spNdryshoPuntorin", conn);
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
                cmd.Parameters.AddWithValue("@_Username", p.UserName);
                cmd.Parameters.AddWithValue("@_Passwordi", p.Passwordi);
                int o = cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            return list;

        }
    }
}
