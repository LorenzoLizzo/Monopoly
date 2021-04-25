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
        private List<Pedina> _listaPedine;
        private Banca _banca;
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

        private Banca Banca
        {
            get
            {
                return _banca;
            }
            set
            {
                _banca = value;
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

        public void Setup(Dictionary<Pedina, int> dadiLanciati)
        {
            foreach (Pedina pedina in ListaPedine)
            {
                pedina.Posizione = Tabellone.GetCasella(0);
                Banca.DistribuisciDenaroIniziale(pedina);
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

        public void MuoviPedina(int dado1, int dado2)
        {
            if (ListaPedine.Contains(TurnoAttuale.Pedina))
            {
                if(!TurnoAttuale.Pedina.PedinaInPrigione)
                {
                    int somma = dado1 + dado2;

                    int posizioneAttualePedina = TurnoAttuale.Pedina.Posizione.Numerocasella;

                    TurnoAttuale.Pedina.Posizione = Tabellone.GetCasella(posizioneAttualePedina + somma);

                    if (dado1 != dado2)
                    {
                        TurnoAttuale.NumeroVolteDoppiDadi = 0;
                    }
                    else if (dado1 == dado2 && TurnoAttuale.NumeroVolteDoppiDadi >= 3)
                    {
                        TurnoAttuale.Pedina.Posizione = Tabellone.GetPrigione();
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

        public void CompraProprieta()
        {
            Banca.VendiProprietaAPedina(TurnoAttuale.Pedina);
            CambiaTurno();
        }

        public Asta RifiutaProprieta()
        {
            CambiaTurno();
            Asta asta = new Asta(TurnoAttuale.Pedina.Posizione as Proprieta, ListaPedine);
            return asta;
        }

        public void PagaAffitto()
        {
            int affitto = (TurnoAttuale.Pedina.Posizione as Proprieta).Contratto.Rendita[(TurnoAttuale.Pedina.Posizione as Proprieta).LivelloProprieta];
            TurnoAttuale.Pedina.DenaroPedina -= affitto;
            (TurnoAttuale.Pedina.Posizione as Proprieta).Proprietario.DenaroPedina += affitto;
            CambiaTurno();
        }

        public void CambiaTurno()
        {
            ListaTurni.Enqueue(TurnoAttuale);
            ListaTurni.Dequeue();
        }
    }
}