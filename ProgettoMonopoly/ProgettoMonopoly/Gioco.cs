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
        private Pedina _pedinaPrincipale;
        private Server _server;
        private Tabellone _tabellone;
        private List<Pedina> _listaPedine;
        private Turno _turnoAttuale;
        private Queue<Turno> _listaTurni;

        public Gioco(Tabellone tabellone, Queue<Turno> listaTurni)
        {
            // Setup(listaTurni);
        }

        public Pedina PedinaPrincipale
        {
            get
            {
                return _pedinaPrincipale;
            }
            private set
            {
                _pedinaPrincipale = value;
            }
        }

        public Server Server
        {
            get
            {
                return _server;
            }
            private set
            {
                _server = value;
            }
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

        public Turno TurnoAttuale
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

        /* setup partita 
        private void Setup(Queue<Turno> listaTurni)
        {
            ListaTurni = listaTurni;
            foreach (Turno turno in ListaTurni)
            {
                turno.Pedina.Posizione = Tabellone.GetCasella(0);
                Banca.DistribuisciDenaroIniziale(turno.Pedina);
            }

        }
        */
        public Casella MuoviPedina(int sommaDadi, string nomeGiocatore)
        {
            if (nomeGiocatore == PedinaPrincipale.Nome)
            {
                if (ListaPedine.Contains(TurnoAttuale.Pedina))
                {
                    if (!TurnoAttuale.Pedina.PedinaInPrigione)
                    {
                        int posizioneAttualePedina = TurnoAttuale.Pedina.Posizione.Numerocasella;

                        TurnoAttuale.Pedina.Posizione = Tabellone.GetCasella(posizioneAttualePedina + sommaDadi);

                        if (TurnoAttuale.Pedina.Posizione.Numerocasella < posizioneAttualePedina)
                        {
                            TurnoAttuale.Pedina.DenaroPedina += (Tabellone.GetCasella(0) as Via).PassaggioDalVia;
                        }

                        string messaggio = $"MOVE {sommaDadi}";
                        Server.InviaMessaggio(messaggio);

                        return TurnoAttuale.Pedina.Posizione;
                    }
                    else
                    {
                        return TurnoAttuale.Pedina.Posizione; //implementa prigione
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                foreach (Pedina pedina in ListaPedine)
                {
                    if (pedina.Nome == nomeGiocatore)
                    {
                        int posizioneAttualePedina = pedina.Posizione.Numerocasella;
                        pedina.Posizione = Tabellone.GetCasella(posizioneAttualePedina + sommaDadi);

                        return pedina.Posizione;
                    }
                }
                throw new Exception();
            }
        }

        public void CompraProprieta()
        {
            if (TurnoAttuale.Pedina.Posizione is Proprieta && (TurnoAttuale.Pedina.Posizione as Proprieta).Comprata == false)
            {
                TurnoAttuale.Pedina.DenaroPedina -= (TurnoAttuale.Pedina.Posizione as Proprieta).Contratto.ValoreContratto;
                TurnoAttuale.Pedina.ListaProprieta.Add(TurnoAttuale.Pedina.Posizione as Proprieta);

                string messaggio = $"BUY {TurnoAttuale.Pedina.Posizione.Numerocasella}";

                Server.InviaMessaggio(messaggio);
            }
            else
            {
                throw new Exception();
            }
        }

        public void RifiutaProprieta()
        {
            string messaggio = $"NOBUY";
            Server.InviaMessaggio(messaggio);
        }

        /* rifiuta proprieta e apri asta
        public Asta RifiutaProprieta()
        {
            Asta asta = new Asta(TurnoAttuale.Pedina.Posizione as Proprieta, ListaPedine);
            return asta;
        }
        */
        public void PagaAffitto()
        {
            int affitto = (TurnoAttuale.Pedina.Posizione as Proprieta).Contratto.Rendita[(TurnoAttuale.Pedina.Posizione as Proprieta).LivelloProprieta];
            TurnoAttuale.Pedina.DenaroPedina -= affitto;
            (TurnoAttuale.Pedina.Posizione as Proprieta).Proprietario.DenaroPedina += affitto;
        }

        /* TODO da fare che si miglira la proprietà solo nel proprio turno
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
        */

        /* paga tassa
        public void PagaTassa()
        {
            TurnoAttuale.Pedina.DenaroPedina -= (TurnoAttuale.Pedina.Posizione as Tassa).Costo;
            Banca.DenaroBanca += (TurnoAttuale.Pedina.Posizione as Tassa).Costo;
        }
        */
        public void Ipoteca(List<Proprieta> proprieta)
        {
            //chiamato quando si sceglie di ipotecare
            foreach (Proprieta item in proprieta)
            {
                TurnoAttuale.Pedina.ListaProprieta.Remove(item);
                TurnoAttuale.Pedina.DenaroPedina += item.Contratto.ValoreIpotecato;
                string messaggio = $"IPOTECA {item.Numerocasella}";
                Server.InviaMessaggio(messaggio);
            } 
        }

        public void NonIpoteca()
        {
            string messaggio = $"NOIPOTECA";
            Server.InviaMessaggio(messaggio);
        }

        public void CambiaTurno()
        {
            ListaTurni.Enqueue(TurnoAttuale);
            ListaTurni.Dequeue();
        }
        
       
    }
}