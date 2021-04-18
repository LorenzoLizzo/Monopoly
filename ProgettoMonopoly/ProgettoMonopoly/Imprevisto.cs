using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Imprevisto : Casella
    {
        private List<CartaImprevisto> _listaImprevisti;

        public Imprevisto(string nomeCasella, List<CartaImprevisto> listaImprevisti):base(nomeCasella)
        {
            ListaImprevisti = listaImprevisti;
        }

        public List<CartaImprevisto> ListaImprevisti
        {
            get
            {
                return _listaImprevisti;
            }
            private set
            {
                _listaImprevisti = value;
            }
        }

        public CartaImprevisto Pesca()
        {
            CartaImprevisto cartaPescata = ListaImprevisti[0];

            ListaImprevisti.RemoveAt(0);
            ListaImprevisti.Add(cartaPescata);
            
            return cartaPescata;
        }

    }
}