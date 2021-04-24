using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Imprevisto : Casella
    {
        public Imprevisto(string nomeCasella, uint numeroCasella) : base(nomeCasella, numeroCasella)
        {

        }

        public CartaImprevisto Pesca(ref MazzoImprevisti mazzo)
        {
            CartaImprevisto cartaPescata = mazzo.ListaImprevisti[0];

            mazzo.ListaImprevisti.RemoveAt(0);
            mazzo.ListaImprevisti.Add(cartaPescata);
            
            return cartaPescata;
        }

    }
}