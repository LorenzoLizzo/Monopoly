using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class ContrattoStrada : Contratto
    {
        private string _colore;
        private float _costoPerCasa;
        
        public ContrattoStrada(string nomeContratto, float valoreContratto, List<float> rendita, string colore): base(nomeContratto, valoreContratto, rendita)
        {
            
        }

        public string Colore
        {
            get
            {
                return _colore;
            }
            private set
            {
                _colore = value;
            }
        }

        public float CostoPerCasa
        {
            get
            {
                return _costoPerCasa;
            }
            private set
            {
                _costoPerCasa = value;
            }
        }
    }
}