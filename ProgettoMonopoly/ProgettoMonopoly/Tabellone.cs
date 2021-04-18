using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Tabellone
    {
        private Dictionary<int,Casella> _listaCaselle;
        private List<Pedina> _listaPedine;

        public Tabellone(Dictionary<int, Casella> listaCaselle, List<Pedina> listaPedine)
        {
            ListaCaselle = listaCaselle;
            ListaPedine = listaPedine;
        }

        public Dictionary<int, Casella> ListaCaselle
        {
            get
            {
                return _listaCaselle;
            }
            private set
            {
                _listaCaselle = value;
            }
        }

        public List<Pedina> ListaPedine
        {
            get
            {
                return _listaPedine;
            }
            private set
            {
                _listaPedine = value;
            }
        }

        public List<Proprieta> TrovaListaProprieta()
        {
            List<Proprieta> listaProprieta = new List<Proprieta>();
            for (int i = 1; i < ListaCaselle.Count; i++)
            {
                Casella casella = GetCasella(i);
                if (casella is Proprieta)
                {
                    listaProprieta.Add(casella as Proprieta);
                }
            }
            return listaProprieta;
        }

        public Casella GetCasella(int indice)
        {
            Casella casella;
            ListaCaselle.TryGetValue(indice, out casella);
            return casella;
        }


    }
}