using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ProgettoMonopoly
{
    public class MazzoProbabilita
    {
        private ObservableCollection<CartaProbabilita> _listaProbabilita;

        public MazzoProbabilita(ObservableCollection<CartaProbabilita> listaProbabilita)
        {
            ListaProbabilita = listaProbabilita;
            MischiaMazzo();
        }

        public ObservableCollection<CartaProbabilita> ListaProbabilita
        {
            get
            {
                return _listaProbabilita;
            }
            private set
            {
                _listaProbabilita = value;
            }
        }

        private void MischiaMazzo()
        {
            Random r = new Random();
            int i = ListaProbabilita.Count;
            while (i > 1)
            {
                i--;
                int numeroEstratto = r.Next(i + 1);
                CartaProbabilita carta = ListaProbabilita[numeroEstratto];
                ListaProbabilita[numeroEstratto] = ListaProbabilita[i];
                ListaProbabilita[i] = carta;
            }
        }
    }
}