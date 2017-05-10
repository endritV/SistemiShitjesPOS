using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemiShitjesPOS.DataAccessLayer;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.BusinessLayer
{
    public class blEmployees
    {

        public static void InsertNewEmployees(Puntori puntori)
        {
            dalEmployees.Insert(puntori);
        }

        public static List<Puntori> GetAll()
        {
            return dalEmployees.GetAll();
        }

        public static List<Puntori> GetEmplyoeeById(string id)
        {

            return dalEmployees.GetEmplyoeeByiD(id);
        }

        public static List<Puntori> UpdateEmplyoee(Puntori puntori)
        {
            return dalEmployees.UpdateEmployee(puntori);
            

        }
    }
}
