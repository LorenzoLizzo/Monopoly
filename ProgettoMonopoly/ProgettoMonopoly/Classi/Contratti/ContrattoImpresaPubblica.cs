using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class ContrattoImpresaPubblica : Contratto
    {
        public ContrattoImpresaPubblica(string nomeContratto, float valoreContratto, List<float> rendita) : base(nomeContratto, valoreContratto, rendita)
        {

        }
    }
}