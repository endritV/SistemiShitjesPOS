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

        public static void InsertNewClietn(Klienti klienti)
        {
            if (IsValid(klienti))
                dalKlineti.Insert(klienti);

        }

        private static bool IsValid(Klienti klienti)
        {
            if (klienti.IdKlienti != "" && klienti.Adresani != "" & klienti.Emri != "" &  klienti.IsKlient == true 
                & klienti.NrTelefonit != "")
                return true;
            return false;


        }
        public static List<Klienti> GETALL()
        {
            return dalKlineti.GetAll();
        }
    }
}
