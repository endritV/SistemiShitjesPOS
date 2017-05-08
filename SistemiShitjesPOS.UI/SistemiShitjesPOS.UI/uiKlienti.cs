using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.UI
{
    public class uiKlienti
    {
        public static List<Klienti> GetKlient(string kl)
        {

            return dalKlineti.GetKlietnById(kl);
        }
    }

}
