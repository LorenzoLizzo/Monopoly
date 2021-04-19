using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Proprieta : Casella
    {
        private List<float> _prezzo;
        private bool _comprata;
        private List<float> _rendita;
        public Proprieta(uint numeroCasella, string nome, List<float> prezzo, List<float> rendita) : base(nome, numeroCasella)
        {
            Prezzo = prezzo;
            Comprata = false;
            Rendita = rendita;
        }

        public List<float> Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }

        public List<float> Rendita
        {
            get
            {
                return _rendita;
            }
            set
            {
                _rendita = value;
            }
        }

        public bool Comprata
        {
            get
            {
                return _comprata;
            }
            set
            {
                _comprata = value;
            }
        }

        
    }
}