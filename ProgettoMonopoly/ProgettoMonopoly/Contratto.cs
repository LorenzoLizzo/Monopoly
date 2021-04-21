using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public abstract class Contratto
    {
        private string _nomeContratto;
        private float _valoreContratto;
        protected List<float> _rendita;

        public Contratto(string nomeContratto, float valoreContratto, List<float> rendita)
        {
            NomeContratto = nomeContratto;
            ValoreContratto = valoreContratto;
            Rendita = rendita;
        }

        public string NomeContratto
        {
            get
            {
                return _nomeContratto;
            }
            private set
            {
                _nomeContratto = value;
            }
        }

        public float ValoreContratto
        {
            get
            {
                return _valoreContratto;
            }
            private set
            {
                _valoreContratto = value;
            }
        }

        public float ValoreIpotecato
        {
            get
            {
                return ValoreContratto / 2;
            }
            private set
            {

            }
        }

        public abstract List<float> Rendita { get; set; }




    }
}