using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ProgettoMonopoly
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Server server;
        public MainWindow()
        {
            InitializeComponent();
            server = new Server();
        }

        private void btnInviaRichiestaGioco_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string richiestaGioco = $"INSERT {txtBoxNome.Text}";
                server.InviaMessaggio(richiestaGioco);
                ControlloStatoPartita();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void ControlloStatoPartita()
        {
            try
            {
                await Task.Run(() =>
                {
                    bool giaEntrato = false;
                    while (true)
                    {
                        if (server.InLobby && giaEntrato)
                        {
                            giaEntrato = true;
                            MessageBox.Show("Sei stato inserito nella partita, aspetta che tutti i giocatori si uniscano");
                        }
                        else if (server.InGame)
                        {
                            FinestraDiGioco finestraDiGioco = new FinestraDiGioco(server);
                            finestraDiGioco.Show();
                            this.Close();
                        }
                        else if (server.Errore != null)
                        {
                            MessageBox.Show(server.Errore);
                        }
                        Thread.Sleep(1);
                    }

                });
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
