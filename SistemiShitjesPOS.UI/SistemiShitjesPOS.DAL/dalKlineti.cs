using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.DataAccessLayer
{
    public class dalKlineti
    {
        private static List<Klienti> _listOfKlient = new List<Klienti>();

        public static void Insert(Klienti klienti)
        {
            _listOfKlient.Add(klienti);
        }

        public static void Update(Klienti klienti)
        {
            foreach (Klienti oldKlient in _listOfKlient)
            {
                if (klienti.NrBiznesit == oldKlient.NrBiznesit)
                {
                    oldKlient.Emri = klienti.Emri;
                }
            }
        }

        public static void Remove(string nrBiznesit)
        {
            var cmp = GetSingleKlinet(nrBiznesit);
            _listOfKlient.Remove(cmp); 
        }

        public static Klienti GetSingleKlinet(string nrBiznesit)
        {
            foreach (Klienti klienti in _listOfKlient)
            {
                if (klienti.NrBiznesit == nrBiznesit)
                    return klienti;
            }
            return null;
        }
    }
}
