using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    class FaturatHyrseDalse
    {
        public bool IsKlient { get; set; }

        private int _idFatura;
        private int _idKlienti;
        private DateTime _dataFatures;
        private int _nrFiskal;


        public int NrFiskal
        {
            get { return _nrFiskal; }
            set {if (value <= 0)
                    throw new Exception("Numri Fiska eshte e zbrazet! Shkruani Numrin Fiskal");
                else
                    _nrFiskal = value; }
        }


        public DateTime DataFatures
        {
            get { return _dataFatures; }
            set {if (value == null)
                    throw new Exception("Data e Fatures eshte e zbrazet! Shkruani Daten");
                else
                    _dataFatures = value; }
        }


        public int IdKlineti
        {
            get { return _idKlienti; }
            set {if (value <= 0)
                    throw new Exception("Id Klienti eshte e zbrazet! Shkruani ID");
            else
                _idKlienti = value; }
        }


        public int IdFatura
        {
            get { return _idFatura; }
            set
            {
                if (value <= 0)
                    throw new Exception("Id e Fatures eshte e zbrazet! Shkruani ID");
                else
                    _idFatura = value;
            }
        }

    }
}
