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

       

        public static void InsertNewItems(Artikulli artikulli)
        {
            //if (IsValid(artikulli))
                dalItems.Insert(artikulli);
           
        }
        public static List<Artikulli> SearchById(int artikulli)
        {

            return dalItems.GetItemsByID(artikulli);

        }

        public static List<Artikulli> UpdateItem(Artikulli artikulli)
        {

            return dalItems.UpdateItem(artikulli);
        }

        public static List<Artikulli>DeleteArtikulli(int barkodi)
        {

            return dalItems.DeleteItemByBarcod(barkodi);
        }


        //public static bool IsValid(Artikulli artikulli)
        //{
        //    if (artikulli.EmriArtikullit != "" && artikulli.Barkodi > 0 && artikulli.Pershkrimi != "" && artikulli.Njesia != "Unity" && artikulli.IsAktiv != false)
        //        return true;
        //    return false;
        //}
    }
}
