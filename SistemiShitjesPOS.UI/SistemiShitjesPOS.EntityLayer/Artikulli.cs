using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    class Artikulli
    {
        private int _idArtukulli;
        private string _emriArtikullit;
        private string _barkodi;
        private string _njesia;
        private string _pershkrimi;
        public bool IsAktiv { get; set; }

        public string Pershkrimi
        {
            get { return _pershkrimi; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Pershkrimi eshte i zbrazet");
                }
                _pershkrimi = value; }
        }


        public string Njesia
        {
            get { return _njesia; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Njesia eshte e zbrazet");
                }
                _njesia = value; }
        }


        public string Barkodi
        {
            get { return _barkodi; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Barkodi eshte i zbrazet");
                }
                _barkodi = value; }
        }


        public int IdArtikulli
        {
            get { return _idArtukulli; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Artikulli eshte i zbazet");
                }
                _idArtukulli = value;
            }
        }
        
        public string EmriArtikullit
        {
            get { return _emriArtikullit; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Emri i Artikullit eshte i zbazet");
                }
                _emriArtikullit = value;      
            }
                
        }
    


    }
}
