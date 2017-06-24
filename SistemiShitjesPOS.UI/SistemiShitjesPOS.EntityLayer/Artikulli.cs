using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    public class Artikulli
    {
        #region Constructor
        public Artikulli()
        {

        }
        public Artikulli(string emriArtikullit,int barkodi,string pershkrimi,string njesia)
        {
            
            EmriArtikullit = emriArtikullit;
            Barkodi = barkodi;
            Pershkrimi = pershkrimi;
            Njesia = njesia;
        }
        public Artikulli(int artikulli,string emriArtikullit, int barkodi, string pershkrimi, string njesia ,double cmimi)
        {
            this.IdArtikulli = artikulli;
            EmriArtikullit = emriArtikullit;
            Barkodi = barkodi;
            Pershkrimi = pershkrimi;
            Njesia = njesia;
            this.Cmimi = cmimi;
            
        }

        #endregion

        private int _idArtukulli;
        private string _emriArtikullit;
        private int _barkodi;
        
        private string _njesia;
        private double _cmimi;
      

        private string _pershkrimi;
        public bool IsAktiv { get; set; }

        public double Cmimi { get { return _cmimi; } set { _cmimi = value; } }


        

        public string Pershkrimi
        {
            get { return _pershkrimi; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Pershkrimi eshte i zbrazet");
                }
                _pershkrimi = value;
            }
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
                else
                    _njesia = value;
            }
        }


        public int Barkodi
        {
            get { return _barkodi; }
            set
            {
               
                _barkodi = value;
            }
        }


        public int IdArtikulli
        {
            get { return _idArtukulli; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Artikulli eshte i zbazet, Mbushe nje");
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
