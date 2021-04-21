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
        public Proprieta(uint numeroCasella, string nome, Contratto contratto) : base(nome, numeroCasella)
        {
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

        
    }
}