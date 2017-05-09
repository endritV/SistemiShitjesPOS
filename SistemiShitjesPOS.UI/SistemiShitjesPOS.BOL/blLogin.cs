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
using System.Security.Cryptography;

namespace SistemiShitjesPOS.BusinessLayer
{
    public class blLogin
    {
        public static string AdminVerification(string user, string pw)
        {
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(pw))
            {
                return dalLogin.AdminVerification(user, pw);
            }
            throw new Exception("User or Password not valid!");
        }
    }
}
