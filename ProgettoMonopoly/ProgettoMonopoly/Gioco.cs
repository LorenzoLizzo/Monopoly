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

        private Turno _turnoAttuale;
        private Queue<Turno> _listaTurni;

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

        private Turno TurnoAttuale
        {
            get
            {
                return ListaTurni.Peek();
            }
            set
            {
                _turnoAttuale = value;
            }
        }

        public Queue<Turno> ListaTurni
        {
            get
            {
                return _listaTurni;
            }
            set
            {
                _listaTurni = value;
            }
        }

        public void Setup(Banca banca, Dictionary<Pedina, int> dadiLanciati)
        {
            foreach (Pedina pedina in ListaPedine)
            {
                pedina.Posizione = Tabellone.GetCasella(0);
                banca.DistribuisciDenaroIniziale(pedina);
            }
            DeterminaTurni(dadiLanciati);
        }

        private void DeterminaTurni(Dictionary<Pedina, int> dadiLanciati)
        {
            dadiLanciati.OrderByDescending(key => key.Value);

            foreach (KeyValuePair<Pedina,int> riga in dadiLanciati)
            {
                Turno turno = new Turno(riga.Key);
                ListaTurni.Enqueue(turno);
            }

        }

        public void MuoviPedina(Pedina pedina, int dado1, int dado2)
        {
            if (ListaPedine.Contains(pedina) && TurnoAttuale.Pedina.Equals(pedina))
            {
                if(!pedina.PedinaInPrigione)
                {
                    int somma = dado1 + dado2;

                    int posizioneAttualePedina = pedina.Posizione.Numerocasella;

                    pedina.Posizione = Tabellone.GetCasella(posizioneAttualePedina + somma);

                    if (dado1 != dado2)
                    {
                        TurnoAttuale.NumeroVolteDoppiDadi = 0;
                        ListaTurni.Enqueue(TurnoAttuale);
                        ListaTurni.Dequeue();
                    }
                    else if (dado1 == dado2 && TurnoAttuale.NumeroVolteDoppiDadi >= 3)
                    {
                        pedina.Posizione = Tabellone.GetPrigione();
                    }
                }
                else
                {

                }

               
            }
            else
            {
                throw new Exception();
            }
        }
    }
}