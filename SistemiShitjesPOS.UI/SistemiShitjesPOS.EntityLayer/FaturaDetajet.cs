using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    class FaturaDetajet
    {
        private int _idFatura;
        private int _idArtikulli;
        private int _sasia;
        private int _cmimi;

        public int Cmimi
        {
            get { return _cmimi; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Cmimi eshte i zbrazet");
                }
                else
                _cmimi = value; }
        }


        public int Sasia
        {
            get { return _sasia; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Sasia eshte e zbrazet");
                }
                _sasia = value; }
        }


        public int IdArtikulli
        {
            get { return _idArtikulli; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id e Artikullit eshte e zbarzet");
                } _idArtikulli = value; }
        }


        public int IdFatura
        {
            get { return _idFatura; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id e Fatures eshte e zbrazet");
                }
                _idFatura = value; }
        }
        

    }
}
