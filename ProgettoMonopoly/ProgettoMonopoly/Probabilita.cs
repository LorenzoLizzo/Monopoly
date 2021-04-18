using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Probabilita : Casella
    {
        private List<CartaProbabilita> _listaProbabilita;

        public Probabilita(string nomeCasella, List<CartaProbabilita> listaProbabilita) : base(nomeCasella)
        {
            ListaProbabilita = listaProbabilita;
        }

        public List<CartaProbabilita> ListaProbabilita
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

        public CartaProbabilita Pesca()
        {
            CartaProbabilita cartaPescata = ListaProbabilita[0];

            ListaProbabilita.RemoveAt(0);
            ListaProbabilita.Add(cartaPescata);

            return cartaPescata;
        }
    }
}