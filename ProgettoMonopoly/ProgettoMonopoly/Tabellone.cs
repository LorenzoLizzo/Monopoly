using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ProgettoMonopoly
{
    public class Tabellone
    {
        private Dictionary<int,Casella> _listaCaselle;
        private ObservableCollection<Pedina> _listaPedine;
        private MazzoImprevisti _mazzoImprevisti;
        private MazzoProbabilita _mazzoProbabilita;
        private Dictionary<int, int> _listaBanconote; //chiave tipo banconata es:500 valore numero di quelle banconote es:2

        public Tabellone(Dictionary<int, Casella> listaCaselle, ObservableCollection<Pedina> listaPedine, MazzoImprevisti mazzoImprevisti,
            MazzoProbabilita mazzoProbabilita, Dictionary<int, int> listaBanconote)
        {
            ListaCaselle = listaCaselle;
            ListaPedine = listaPedine;
            MazzoImprevisti = mazzoImprevisti;
            MazzoProbabilita = mazzoProbabilita;
            ListaBanconote = listaBanconote;
        }

        public Tabellone()
        {

        }

        private Dictionary<int, Casella> ListaCaselle
        {
            get
            {
                return _listaCaselle;
            }
            set
            {
                _listaCaselle = value;
            }
        }

        private ObservableCollection<Pedina> ListaPedine
        {
            get
            {
                return _listaPedine;
            }
            set
            {
                _listaPedine = value;
            }
        }

        public MazzoImprevisti MazzoImprevisti
        {
            get
            {
                return _mazzoImprevisti;
            }
            private set
            {
                _mazzoImprevisti = value;
            }
        }

        public MazzoProbabilita MazzoProbabilita
        {
            get
            {
                return _mazzoProbabilita;
            }
            private set
            {
                _mazzoProbabilita = value;
            }
        }

        private Dictionary<int, int> ListaBanconote
        {
            get
            {
                return _listaBanconote;
            }
            set
            {
                _listaBanconote = value;
            }
        }

        public Casella GetCasella(int indice)
        {
            Casella casella;
            ListaCaselle.TryGetValue(indice, out casella);
            return casella;
        }


    }
}