using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Proprieta : Casella
    {
        private int _livelloProprieta;
        private float _prezzo;
        private float _valoreIpotecato;
        private bool _comprata;
        private float _rendita;
        public Proprieta(string nome,float prezzo, float valoreIpotecato, float rendita) : base(nome)
        {
            LivelloProprieta = 0;
            Prezzo = prezzo;
            ValoreIpotecato = valoreIpotecato;
            Comprata = false;
            Rendita = rendita;
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

        public float Prezzo
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

        public float ValoreIpotecato
        {
            get
            {
                return _valoreIpotecato;
            }
            private set
            {
                _valoreIpotecato = value / 2;
            }
        }

        public float Rendita
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