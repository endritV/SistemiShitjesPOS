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
        public Klienti(bool isKlient, string idKlienti, string emri, string emriPronarit, string mbiemriPronarit, string numriFix, string adresa, string nrTelefonit, string nrBiznesit, string web, string email,string pershkrimi)
        {
            IsKlient = isKlient;
            IdKlienti = idKlienti;
            Emri = emri;
            EmriPronarit = emriPronarit;
            MbiemriPronarit = mbiemriPronarit;
            NumriFix = numriFix;
            Adresani = adresa;
            NrTelefonit = nrTelefonit;
            NrBiznesit = nrBiznesit;
            Web = web;
            Email = email;
            this.Pershkrimi = pershkrimi;
        }
        public Klienti(bool isKlient, string idKlienti, string emriPronarit, string mbiemriPronarit, string adresa, string nrTelefonit, int pikat)
        {
            IsKlient = isKlient;
            IdKlienti = idKlienti;
            EmriPronarit = emriPronarit;
            MbiemriPronarit = mbiemriPronarit;
            Adresani = adresa;
            NrTelefonit = nrTelefonit;
            Pikat = pikat;
        }
        #endregion

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
        private string _pershkrimi;

        #endregion

        #region NotValidate
        public string Web { get; set; }
        public string Email { get; set; }
        public int Pikat { get; set; }
        #endregion

        #region Properties
        public string Pershkrimi { get { return _pershkrimi; } set { _pershkrimi = value; } }

        public string NrBiznesit
        {
            get { return _nrBiznesit; }
            set
            {
                _nrBiznesit = value;
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


        public string NumriFix
        {
            get { return _numriFix; }
            set
            {
                _numriFix = value;
            }
        }


        public string MbiemriPronarit
        {
            get { return _mbiemriPronarit; }
            set
            {
               _mbiemriPronarit = value;
            }
        }


        public string EmriPronarit
        {
            get { return _emriPronarit; }
            set
            {
              
                 _emriPronarit = value;
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

    }
    #endregion

   
}
