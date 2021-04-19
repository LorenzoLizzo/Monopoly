using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class InPrigione : Casella
    {
        public InPrigione(string nomeCasella, uint numeroCasella) : base(nomeCasella, numeroCasella)
        {
            
        }

        public void SpostaInPrigione(Prigione prigione, Pedina pedina)
        {
            pedina.PedinaInPrigione = true;
            prigione.PedineInPrigione.Add(pedina);
        }
    }
}