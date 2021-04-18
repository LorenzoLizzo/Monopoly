using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Casella
    {
        private string _nomeCasella;

        public Casella(string nomeCasella)
        {
            NomeCasella = nomeCasella;
        }

        public string NomeCasella
        {
            get
            {
                return _nomeCasella;
            }
            private set
            {
                _nomeCasella = value;
            }
        }

    }
}