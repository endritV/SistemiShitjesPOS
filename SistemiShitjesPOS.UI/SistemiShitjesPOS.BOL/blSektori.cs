using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemiShitjesPOS.BusinessLayer;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.BusinessLayer
{
    public  class blSektori
    {

        public static void GetAllSektori()
        {
            dalSektori.GetAll();
        }
    }
}
