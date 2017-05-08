using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.BOL;
using SistemiShitjesPOS.DAL;
using SistemiShitjesPOS.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace SistemiShitjesPOS.UI
{
    public class ArtikulliUI
    {
        public static List<Artikulli> GetItems(int brk)
        {
            return ArtikulliBOL.GetItemByBarkodi(brk);
        }
    }
}
