using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.EntityLayer
{
    class Puntori
    {
        #region Private


        private string _idPuntori;
        private int _idSektori;
        private string _emri;
        private string _mbiemri;
        private DateTime _dataLindjes;
        private string _nrTelefonit;
        private string _email;
        private string _userName;
        private string _password;
        private int _idRoli;
        #endregion

        #region Properties


        public int IdRoli
        {
            get { return _idRoli; }
            set
            {
                if (value <= 0)
                    throw new Exception("Id Roli eshte i zbrazet! Shkruni Rolin");
                else
                    _idRoli = value;
            }
        }


        public string Passwordi
        {
            get { return _password; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("User Name or Password is Incorrect!");
                else _password = value;
            }
        }


        public string UserName
        {
            get { return _userName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("User Name or Password is Incorrect!");
                else _userName = value;
            }
        }


        public string Email
        {
            get { return _email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Email-i eshte i zbrazet! Shkruani nje Email.");
                else _email = value;
            }
        }


        public string NrTelefonit
        {
            get { return _nrTelefonit; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Numri Telefonit eshte i zbrazet! Shkruani Numeri e Telefonit.");
                else _nrTelefonit = value;
            }
        }


        public DateTime DataLindjes
        {
            get { return _dataLindjes; }
            set
            {
                if (value == null)
                    throw new Exception("Data e Lindjes eshte i zbrazet! Shkruani Daten e Lindjes.");
                else _dataLindjes = value;
            }
        }


        public string Mbiemri
        {
            get { return _mbiemri; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Mbiemri eshte i zbrazet! Shkruani nje Mbiemer.");
                else _mbiemri = value;
            }
        }


        public string Emri
        {
            get { return _emri; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Emri eshte i zbrazet! Shkruani nje Emer.");
                else _emri = value;
            }
        }


        public int IdSektori
        {
            get { return _idSektori; }
            set
            {
                if (value <= 0)
                    throw new Exception("Sektori eshte i zbrazet! Shkruani nje Id.");
                else _idSektori = value;
            }
        }


        public string IdPuntori
        {
            get { return _idPuntori; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Id Puntori eshte i zbrazet! Shkruani nje Id.");
                else _idPuntori = value;
            }
        }

    }
    #endregion
}
