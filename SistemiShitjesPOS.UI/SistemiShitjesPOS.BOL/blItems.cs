using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.BusinessLayer
{
    public class blItems
    {
        public static List<Artikulli> GetAll()
        {
            return dalItems.GetAll();
        }
    }
}
