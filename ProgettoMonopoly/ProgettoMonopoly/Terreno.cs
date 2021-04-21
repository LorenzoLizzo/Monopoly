using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Terreno : Proprieta
    {
        private int _livelloProprieta;

        public Terreno(uint numeroCasella, string nome, List<float> prezzo, List<float> rendita) : base(numeroCasella, nome, prezzo, rendita)
        {
            LivelloProprieta = 0;
        }

        public int LivelloProprieta
        {
            get
            {
                return _livelloProprieta;
            }
            set
            {
                _livelloProprieta = value;
            }
        }

       

        
    }
}