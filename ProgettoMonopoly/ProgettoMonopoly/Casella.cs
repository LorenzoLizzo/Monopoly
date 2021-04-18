using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Casella
    {
        private string _nomeCasella;
        private uint _numeroCasella;

        public Casella(string nomeCasella, uint numeroCasella)
        {
            NomeCasella = nomeCasella;
            Numerocasella = numeroCasella;
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

        public uint Numerocasella
        {
            get
            {
                return _numeroCasella;
            }
            private set
            {
                _numeroCasella = value;
            }
        }

    }
}