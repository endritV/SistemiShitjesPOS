﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.EntityLayer;
using System.Data;
using System.Data.SqlClient;


namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalSupplier
    {
        static string cs = DataBaseCon.GetConnectionString();
        public static void Insert(Suppliers k)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("spShtoFurnizuesin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_IdKlienti", k.IdKlienti);
                cmd.Parameters.AddWithValue("@_Emri", k.Emri);
                cmd.Parameters.AddWithValue("@_EmriPronarit", k.EmriPronarit);
                cmd.Parameters.AddWithValue("@_MbiemriPronarit", k.MbiemriPronarit);
                cmd.Parameters.AddWithValue("@_NrFix", k.NumriFix);
                cmd.Parameters.AddWithValue("@_Nrtelefonit", k.NrTelefonit);
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresani);
                cmd.Parameters.AddWithValue("@_NrBiznesit", k.NrBiznesit);
                cmd.Parameters.AddWithValue("@_Email", k.Email);
                cmd.Parameters.AddWithValue("@_Web", k.Web);
                cmd.Parameters.AddWithValue("@_Pershkrimi", k.Pershkrimi);
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static List<Suppliers> GetAll()
        {
            List<Suppliers> list = new List<Suppliers>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spShfaqTeGjitheFurnizuesit", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var klienti = new Suppliers();

                        klienti.IdKlienti = reader["IdKlienti"].ToString();
                        klienti.IsKlient = bool.Parse(reader["IsKlinet"].ToString());
                        klienti.EmriPronarit = reader["EmriPronarit"].ToString();
                        klienti.MbiemriPronarit = reader["MbimeriPronarit"].ToString();
                        klienti.NumriFix = reader["NrFix"].ToString();
                        klienti.Adresani = reader["Adresa"].ToString();
                        klienti.NrTelefonit = reader["NrTelefonit"].ToString();
                        klienti.NrBiznesit = reader["NrBiznesit"].ToString();
                        klienti.Email = reader["Email"].ToString();
                        klienti.Web = reader["Web"].ToString();
                        klienti.Pershkrimi = reader["Pershkrimi"].ToString();

                        list.Add(klienti);
                    }

                }
            }
            return list;
        }
        public static List<Suppliers> GetSupplierById(string id)
        {
            var list = new List<Suppliers>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spKerkoFurnizuesin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", id);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var klienti = new Suppliers();

                        klienti.IdKlienti = id;
                        klienti.IsKlient = bool.Parse(reader["IsKlinet"].ToString());
                        klienti.EmriPronarit = reader["EmriPronarit"].ToString();
                        klienti.MbiemriPronarit = reader["MbimeriPronarit"].ToString();
                        klienti.NumriFix = reader["NrFix"].ToString();
                        klienti.Adresani = reader["Adresa"].ToString();
                        klienti.NrTelefonit = reader["NrTelefonit"].ToString();
                        klienti.NrBiznesit = reader["NrBiznesit"].ToString();
                        klienti.Email = reader["Email"].ToString();
                        klienti.Web = reader["Web"].ToString();
                        klienti.Pershkrimi = reader["Pershkrimi"].ToString();

                        list.Add(klienti);
                    }

                }
            }
            return list;
        }
        public static List<Suppliers> UpdateSupplier(Suppliers k)
        {
            var list = new List<Suppliers>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spNdryshoFurnitorin", conn);
                cmd.Parameters.AddWithValue("@_IdKlienti", k.IdKlienti);
                cmd.Parameters.AddWithValue("@_Emri", k.Emri);
                cmd.Parameters.AddWithValue("@_EmriPronarit", k.EmriPronarit);
                cmd.Parameters.AddWithValue("@_MbiemriPronarit", k.MbiemriPronarit);
                cmd.Parameters.AddWithValue("@_NrFix", k.NumriFix);
                cmd.Parameters.AddWithValue("@_Nrtelefonit", k.NrTelefonit);
                cmd.Parameters.AddWithValue("@_Adresa", k.Adresani);
                cmd.Parameters.AddWithValue("@_NrBiznesit", k.NrBiznesit);
                cmd.Parameters.AddWithValue("@_Email", k.Email);
                cmd.Parameters.AddWithValue("@_Web", k.Web);
                cmd.Parameters.AddWithValue("@_Pershkrimi", k.Pershkrimi);
                cmd.Parameters.AddWithValue("@_IsKlient", k.IsKlient);
                cmd.CommandType = CommandType.StoredProcedure;
                int o = cmd.ExecuteNonQuery();
                conn.Close();

            }
            return list;

        }
        public static List<Suppliers> DeleteSupplierById(string id)
        {
            var list = new List<Suppliers>();
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
                        var klienti = new Suppliers();

                        klienti.IdKlienti = id;
                        list.Add(klienti);
                    }
                }
                return list;
            }
        }
    }
}
