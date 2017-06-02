using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemiShitjesPOS.EntityLayer
{
     public class Klienti
    {
        



        #region Constructor

        public Klienti()
        {
            //deafult
        }
        public Klienti(string klientiId,string name,string adresa, string nrTellefonit, bool isKlient )
        {
            IdKlienti = klientiId;
            Emri = name;
            Adresani = adresa;
            NrTelefonit = nrTellefonit;
            IsKlient = isKlient;
        }
      
        #endregion

        #region Bool
        public bool IsKlient { get; set; }

        #endregion

        #region Private


        private string _idKlienti;
        private string _emri;
       
        private string _adresa;
        private string _nrTelefonit;
        

        #endregion

        #region NotValidate
        
        public int Pikat { get; set; }
        #endregion

        #region Properties

        public string IdKlienti
        {
            get { return _idKlienti; }
            set
            {
                //if (String.IsNullOrEmpty(value))
                //    throw new Exception("Id Klineti eshte i zbrazet! Shkruani nje Id.");

                _idKlienti = value;
            }
        }

        public string Emri
        {
            get { return _emri; }
            set
            {
                _emri = value;
            }
        }

        public string NrTelefonit
        {
            get { return _nrTelefonit; }
            set
            {
               _nrTelefonit = value;
            }
        }


        public string Adresani
        {
            get { return _adresa; }
            set
            {
              _adresa = value;
            }
        }
    }
    #endregion  
}
