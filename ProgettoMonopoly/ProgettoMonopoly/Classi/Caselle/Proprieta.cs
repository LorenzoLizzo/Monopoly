using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Proprieta : Casella
    {
        private bool _comprata;
        private Contratto _contratto;
        private int _livelloProprieta;
        public Proprieta(uint numeroCasella, string nome, Contratto contratto) : base(nome, numeroCasella)
        {
            LivelloProprieta = 0;
            Comprata = false;
            Contratto = contratto;
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

        public Contratto Contratto
        {
            get
            {
                return _contratto;
            }
            private set
            {
                _contratto = value;
            }
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