using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class MazzoProbabilita
    {
        private List<CartaProbabilita> _listaProbabilita;

        public MazzoProbabilita(List<CartaProbabilita> listaProbabilita)
        {
            ListaProbabilita = listaProbabilita;
            MischiaMazzo();
        }

        public MazzoProbabilita()
        {

        }

        public List<CartaProbabilita> ListaProbabilita
        {
            get
            {
                return _listaProbabilita;
            }
            set
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