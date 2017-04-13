using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemiShitjesPOS.EntityLayer;

namespace SistemiShitjesPOS.EntityLayer
{
    public class Roli
    {
        public bool IsActive { get; set; }

        private string _idRoli;
        private string _emri;

        public string Emri
        {
            get { return _emri; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Emri eshte i zbrazet! Shktuani Emrin");
                else _emri = value;
            }
        }


        public string IdRoli
        {
            get { return _idRoli; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Id Roli eshte i zbrazet! Shktuani Id Rolin");
                else
                    _idRoli = value;
            }
        }

    }
}
