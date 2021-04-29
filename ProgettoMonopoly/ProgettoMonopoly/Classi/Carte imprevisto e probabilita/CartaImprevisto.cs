using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class CartaImprevisto : Carta
    {
        private int _id;
        public CartaImprevisto(string descrizione) : base(descrizione)
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