using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Carta
    {
        private uint _id;
        private string _nome;
        private string _descrizione;
        
        public Carta(uint id, string nome, string descrizione)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
        }

        public uint Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                _nome = value;
            }
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            private set
            {
                _descrizione = value;
            }
        }

    }
}