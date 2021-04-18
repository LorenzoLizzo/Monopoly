using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    /*
     *la banca sarà un bot che implementerò nel main window quando avrò fatto il merge di tutto il progetto
     *to do nel main window:
     *Metodo: per pagare indennità e premi
     *Metodo: per comprare delle case dai giocatori
     *Metodo: per incassare le multe e le tasse
     *Metodo: per vendere le proprietà comprate dai giocatori e gli consegna i contratti
     */
    public class Banca
    {
        float denaroDellaBanca;
        //la banca spende soldi solo comprando case dai giocatori e pagando le indennità ed i premi
        public Banca(float denaro)
        {
            DenaroDellaBanca = denaro;
        }

        public float DenaroDellaBanca
        {
            get
            {
                return denaroDellaBanca;
            }
            set
            {
                denaroDellaBanca = value;
            }
        }
    }
}