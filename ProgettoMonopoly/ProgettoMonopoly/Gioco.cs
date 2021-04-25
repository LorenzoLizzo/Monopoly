using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ProgettoMonopoly
{
    public class Gioco
    {
        private const int _passaggioDalVia = 200;
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

                    if(TurnoAttuale.Pedina.Posizione.Numerocasella < posizioneAttualePedina)
                    {
                        Banca.PagaPassaggioDalVia(TurnoAttuale.Pedina, _passaggioDalVia);
                    }

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

        public async void MiglioraProprieta(Proprieta proprieta) // solo strada
        {
            await Task.Run(() =>
            {
                if (proprieta.LivelloProprieta == 0)
                {
                    if (proprieta is Strada)
                    {
                        int i = 0;
                        foreach (Proprieta prop in (proprieta as Strada).Distretto.ListaStrade)
                        {
                            if (proprieta.Proprietario.ListaProprieta.Contains(prop))
                            {
                                i++;
                            }
                        }

                        if (i == (proprieta as Strada).Distretto.ListaStrade.Count)
                        {
                            proprieta.LivelloProprieta++; //migliora anche livello delle altre due proprietà
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }
                else if (proprieta.LivelloProprieta > 0 && proprieta.LivelloProprieta < proprieta.Contratto.Rendita.Count) // e le altre due porprietà sono al tuo stesso livello o al massimo uno sotto
                {
                    proprieta.Proprietario.DenaroPedina -= (proprieta.Contratto as ContrattoStrada).CostoPerCasa;
                    Banca.DenaroBanca += (proprieta.Contratto as ContrattoStrada).CostoPerCasa;
                    proprieta.LivelloProprieta++;
                }
            });

            
        }

        public void PagaTassa()
        {
            TurnoAttuale.Pedina.DenaroPedina -= (TurnoAttuale.Pedina.Posizione as Tassa).Costo;
            Banca.DenaroBanca += (TurnoAttuale.Pedina.Posizione as Tassa).Costo;
        }

        

        
    }
}