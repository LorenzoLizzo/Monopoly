using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Proprieta : Casella
    {
        private float _prezzo;
        private float _valoreIpotecato;
        private bool _comprata;
        public Proprieta(string nome, float prezzo) : base(nome)
        {
            Prezzo = prezzo;
            ValoreIpotecato = Prezzo;
            Comprata = false;
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