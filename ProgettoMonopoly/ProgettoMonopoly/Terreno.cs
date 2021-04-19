using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Terreno : Proprieta
    {
        private int _livelloProprieta;
        private float _valoreIpotecato;

        public Terreno(uint numeroCasella, string nome, List<float> prezzo, float valoreIpotecato, List<float> rendita) : base(numeroCasella, nome, prezzo, rendita)
        {
            LivelloProprieta = 0;
            ValoreIpotecato = valoreIpotecato;
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

        public float ValoreIpotecato
        {
            get
            {
                return Prezzo[0] / 2;
            }
            private set
            {

            }
        }
    }
}