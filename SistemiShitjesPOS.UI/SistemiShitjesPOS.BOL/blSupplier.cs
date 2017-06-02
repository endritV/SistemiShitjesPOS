
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;


namespace SistemiShitjesPOS.BusinessLayer
{
    public class blSupplier
    {

        public static void InsertNewSupplier(Suppliers klienti)
        {       
               dalSupplier.Insert(klienti);
        }

        public static List<Suppliers> GETALL()
        {
            return dalSupplier.GetAll();
        }

        public static List<Suppliers> GetSupplierByid(string klienti)
        {
            return dalSupplier.GetSupplierById(klienti);
        }

        public static List<Suppliers> UpdateSupplier(Suppliers klienti)
        {

            return dalSupplier.UpdateSupplier(klienti);
        }

        public static List<Suppliers> DeleteSupplier(string furnitori)
        {
            return dalSupplier.DeleteSupplierById(furnitori);

        }


    }
}
