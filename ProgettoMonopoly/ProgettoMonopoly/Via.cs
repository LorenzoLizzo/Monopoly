using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Via : Casella
    {
        private const int _valore = 400;
        public Via(string nomeCasella, uint numeroCasella) : base(nomeCasella, numeroCasella)
        {

        }

        public void Paga(Pedina pedina)
        {
            pedina.DenaroPedina += _valore;
        }
    }
}