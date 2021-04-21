using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class ContrattoStazione : Contratto
    {
        public ContrattoStazione(string nomeContratto, float valoreContratto, List<float> rendita) : base(nomeContratto, valoreContratto)
        {
            Rendita = rendita;
        }

        public List<float> Rendita
        {
            get
            {
                return _rendita;
            }
            private set
            {
                _rendita = value;
                foreach (float prezzo in value)
                {
                    _renditaAvanzata.Add(prezzo * 2);
                }
            }
        }

        public List<float> RenditaAvanzata
        {
            get
            {
                return _renditaAvanzata;
            }
            set
            {

            }
        }


    }
}