using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    public class FaturatHyrseDalse
    {
        public bool IsKlient { get; set; }
        public bool IsHyrse { get; set; }

        private int _idFatura;
        private int _idKlienti;
        private DateTime _dataFatures;
        private int _nrFiskal;
        private int _nrTVSH;
        private int _nrKuponit;
        private int _idPuntori;


        public int IdPuntorit
        {
            get { return _idPuntori; }
            set {
                if (value <= 0)
                    throw new Exception("Id Puntori eshte e zbrazet! Shkruani ID");
                else _idPuntori = value; }
        }


        public int NrKuponit
        {
            get { return _nrKuponit; }
            set {
                if (value <= 0)
                    throw new Exception("Numri Kuponit eshte e zbrazet! Shkruani Numrin e Kuponit");
                else _nrKuponit = value; }
        }


        public int TVSH
        {
            get { return _nrTVSH; }
            set {
                if (value <= 0)
                    throw new Exception("Numri TVSH-se eshte e zbrazet! Shkruani Numrin e TVSH-se");
                else _nrTVSH = value; }
        }



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
