using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ProgettoMonopoly
{
    public class MazzoImprevisti
    {
        private ObservableCollection<CartaImprevisto> _listaImprevisti;

        public MazzoImprevisti(ObservableCollection<CartaImprevisto> listaImprevisti)
        {
            ListaImprevisti = listaImprevisti;
            MischiaMazzo();
        }

        public ObservableCollection<CartaImprevisto> ListaImprevisti
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