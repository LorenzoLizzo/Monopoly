using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ProgettoMonopoly
{
    public class Gioco
    {
        private Tabellone _tabellone;
        private ObservableCollection<Pedina> _listaPedine;
        public Gioco(Tabellone tabellone)
        {

        }

        private Tabellone Tabellone
        {
            get
            {
                return _tabellone;
            }
            set
            {
                _tabellone = value;
            }
        }

        public ObservableCollection<Pedina> ListaPedine
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

        public void IniziaGioco()
        {
            foreach (Pedina pedina in ListaPedine)
            {
                pedina.Posizione = Tabellone.GetCasella(0);
                pedina.DenaroPedina = 1500;
            }
        }

        public void MuoviPedina(Pedina pedina, int dado1, int dado2)
        {
            if (ListaPedine.Contains(pedina) && !pedina.PedinaInPrigione)
            {
                int somma = dado1 + dado2;

                int posizioneAttualePedina = pedina.Posizione.Numerocasella;

                pedina.Posizione = Tabellone.GetCasella(posizioneAttualePedina + somma);

            }
            else
            {
                throw new Exception();
            }
        }

       

    }
}