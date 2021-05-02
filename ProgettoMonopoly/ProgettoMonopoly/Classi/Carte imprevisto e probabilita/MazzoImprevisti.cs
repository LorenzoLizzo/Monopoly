using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class MazzoImprevisti
    {
        private List<CartaImprevisto> _listaImprevisti;

        public MazzoImprevisti(List<CartaImprevisto> listaImprevisti)
        {
            ListaImprevisti = listaImprevisti;
            MischiaMazzo();
        }

        public MazzoImprevisti()
        {

        }

        public List<CartaImprevisto> ListaImprevisti
        {
            get
            {
                return _listaImprevisti;
            }
            set
            {
                _listaImprevisti = value;
            }
        }

        private void MischiaMazzo()
        {
            Random r = new Random();
            int i = ListaImprevisti.Count;
            while (i > 1)
            {
                i--;
                int numeroEstratto = r.Next(i + 1);
                CartaImprevisto carta = ListaImprevisti[numeroEstratto];
                ListaImprevisti[numeroEstratto] = ListaImprevisti[i];
                ListaImprevisti[i] = carta;
            }
        }
    }
}