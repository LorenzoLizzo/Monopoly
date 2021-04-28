using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace ProgettoMonopoly
{
    public class Server
    {
        private const int _portaServer = 2021;
        private int _portaClient;
        private Socket _socket;
        private EndPoint _endPointLocale;

        private bool _inLobby;
        private bool _inGame;
        private string _errore;

        public Server()
        {
            Socket = new Socket(SocketType.Dgram, ProtocolType.IP); //da sistemare per tcp
            EndPointLocale = new IPEndPoint(IPAddress.Any, 0);
        }

        public bool InLobby
        {
            get
            {
                return _inLobby;
            }
            private set
            {
                _inLobby = value;
            }
        }

        public bool InGame
        {
            get
            {
                return _inGame;
            }
            private set
            {
                _inGame = value;
            }
        }

        public string Errore
        {
            get
            {
                return _errore;
            }
            private set
            {
                _errore = value;
            }
        }

        private int PortaClient
        {
            get
            {
                return _portaClient;
            }
            set
            {
                _portaClient = value;
            }
        }

        public Socket Socket
        {
            get
            {
                return _socket;
            }
            set
            {
                _socket = value;
            }
        }

        public EndPoint EndPointLocale
        {
            get
            {
                return _endPointLocale;
            }
            set
            {
                _endPointLocale = value;
            }
        }

        public async void RicezioneMessaggi()
        {
            await Task.Run(() =>
            {
                while (true)
                {

                    if (Socket.Available != 0)
                    {
                        // Ricezione
                        byte[] dati = new byte[1024];
                        int ricevuto = Socket.ReceiveFrom(dati, ref _endPointLocale);

                        // Decodifica
                        string messaggioRicezione = Encoding.ASCII.GetString(dati, 0, ricevuto);

                        RispostaServer(messaggioRicezione);
                    }
                    Thread.Sleep(1);
                }

            });

        }

        public void EntraPartita(string nomeGiocatore)
        {
            string richiestaGioco = $"INSERT {nomeGiocatore}";

            byte[] dati = Encoding.ASCII.GetBytes(richiestaGioco);

            IPEndPoint endPointRemoto = new IPEndPoint(IPAddress.Parse("*****"), _portaServer); // da inserire server

            Socket.SendTo(dati, endPointRemoto);
        }

        private void RispostaServer(string messaggioRicezione)
        {
            if (messaggioRicezione.Contains("INSERTOK"))
            {
                PortaClient = int.Parse(messaggioRicezione.Split(' ')[1]);
                InLobby = true;
                
            }
            else if (messaggioRicezione.Contains("STARTGAME"))
            {
                //implementa
                InGame = true;
            }
            //implementa
        }



    }
}