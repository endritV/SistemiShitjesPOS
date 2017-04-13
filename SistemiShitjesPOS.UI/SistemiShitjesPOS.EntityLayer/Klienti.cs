using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemiShitjesPOS.EntityLayer
{
    public class Klienti
    {
        #region Bool

        
        public bool IsKlient { get; set; }

#endregion

        #region Private

        
        private string _idKlienti;
        private string _emri;
        private string _emriPronarit;
        private string _mbiemriPronarit;
        private string _numriFix;
        private string _adresa;
        private string _nrTelefonit;
        private string _nrBiznesit;

        #endregion

        #region NotValidate

        
        public string Web { get; set; }
        public string Email { get; set; }
        public int Pikat { get; set; }
        #endregion

        #region Properties

        
        public string NrBiznesiit
        {
            get { return _nrBiznesit; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Numri i Biznesit eshte i zbrazet! Shkruani nje Numri te Biznesit.");
                else _nrBiznesit = value; }
        }


        public string NrTelefonit
        {
            get { return _nrTelefonit; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Numri i Telefoni eshte i zbrazet! Shkruani nje Numer.");
                else _nrTelefonit = value; }
        }


        public string Adresa
        {
            get { return _adresa; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Adresa eshte i zbrazet! Shkruani nje Adrese.");
                else _adresa = value; }
        }


        public string NumriFix
        {
            get { return _numriFix; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Numri Fix eshte i zbrazet! Shkruani nje Numer.");
                else _numriFix = value; }
        }


        public string MbiemriPronarit
        {
            get { return _mbiemriPronarit; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Mbiemri i Pronarit eshte i zbrazet! Shkruani nje Mbiemr.");
                else _mbiemriPronarit = value; }
        }


        public string EmriPronarit
        {
            get { return _emriPronarit; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Emri Pronarit eshte i zbrazet! Shkruani nje Emer.");
                else _emriPronarit = value;
            }
        }


        public string Emri
        {
            get { return _emri; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Emri eshte i zbrazet! Shkruani nje Emer.");
                else
                    _emri = value;
            }
        }


        public string IdKlienti
        {
            get { return _idKlienti; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Id Klineti eshte i zbrazet! Shkruani nje Id.");
                else
                    _idKlienti = value;
            }
        }

    }
    #endregion
}
