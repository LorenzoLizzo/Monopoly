using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ProgettoMonopoly
{
    public class Probabilita : Casella
    {
        public Probabilita(string nomeCasella, int numeroCasella, Thickness margine) : base(nomeCasella, numeroCasella, margine)
        {
            
        }

        public CartaProbabilita Pesca(ref MazzoProbabilita mazzo)
        {
            CartaProbabilita cartaPescata = mazzo.ListaProbabilita[0];

            mazzo.ListaProbabilita.RemoveAt(0);
            mazzo.ListaProbabilita.Add(cartaPescata);

            return cartaPescata;
        }
    }
}