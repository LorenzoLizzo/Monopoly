using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class CartaProbabilita : Carta
    {
        private int _id;
        public CartaProbabilita(string descrizione) : base(descrizione)
        {

        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}