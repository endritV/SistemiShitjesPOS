using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;



namespace SistemiShitjesPOS.BusinessLayer
{
    public class blKlienti
    {
        public static void InsertKlient(Klienti klienti)
        {
            if (klienti != null)
                dalKlineti.Insert(klienti);
            else throw new Exception("Ivalid Company");
        }

        public static void UpdateKlient(Klienti klienti)
        {
            if (klienti != null)
                dalKlineti.Update(klienti);
            else throw new Exception("Invalid Update");
        }
        public static void DeleteKlient(string nrBiznesit)
        {
            if (String.IsNullOrEmpty(nrBiznesit))
                throw new Exception("Invalide Business Number");
            else dalKlineti.Remove(nrBiznesit);
        }

        public static Klienti GetKlient(string nrBiznesit)
        {
            return dalKlineti.GetSingleKlinet(nrBiznesit);
        }
    }
}
