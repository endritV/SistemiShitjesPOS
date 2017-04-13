using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiShitjesPOS.EntityLayer
{
    class Sektori
    {
        private int _idSektori;
        private int _idPuntori;
        private string _emriSektorit;

        public string EmriSektorit 
        {
            get { return _emriSektorit; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Emri i sektorit eshte i zbrazet");
                }
                else
                _emriSektorit = value; }
        }


        public int IdPuntori
        {
            get { return _idPuntori; }
            set
            {
                if (value<= 0)
                {
                    throw new Exception("Id Puntori eshte i zbrazet");
                } _idPuntori = value; }
        }


        public int IdSektori    
        {
            get { return _idSektori; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id e Sektorit eshte e zbarazet");
                } _idSektori = value; }
        }

    }
}
