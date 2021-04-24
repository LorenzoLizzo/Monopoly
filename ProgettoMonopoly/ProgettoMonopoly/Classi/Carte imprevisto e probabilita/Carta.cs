using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Carta
    {
        private string _descrizione;
        
        public Carta(string descrizione)
        {
            Descrizione = descrizione;
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            private set
            {
                _descrizione = value;
            }
        }

    }
}