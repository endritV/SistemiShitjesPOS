
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

        public static void InsertNewSupplier(Klienti klienti)
        {       
               dalSupplier.Insert(klienti);
        }

        public static List<Klienti> GETALL()
        {
            return dalSupplier.GetAll();
        }


    }
}
