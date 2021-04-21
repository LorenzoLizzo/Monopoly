using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class ContrattoTerreno : Contratto
    {
        private string _colore;
        private float _costoPerCasa;
        private Pedina _proprietario;

        public ContrattoTerreno(string nomeContratto, float valoreContratto, List<float> rendita, string colore): base(nomeContratto, valoreContratto, rendita)
        {
            
        }

        public override List<float> Rendita
        {
            get
            {
                int numeroProprietaConStessoColore = 0;

                for (int i = 0; i < Proprietario.ListaProprieta.Count && numeroProprietaConStessoColore < 3; i++)
                {
                    if ((Proprietario.ListaProprieta[i].Contratto as ContrattoTerreno).Colore == this.Colore)
                    {
                        numeroProprietaConStessoColore++;
                    }
                }

                if (numeroProprietaConStessoColore != 3)
                {
                     return _rendita;
                }
                else
                {
                    List<float> renditaRaddoppiata = new List<float>();
                    foreach(float prezzo in _rendita)
                    {
                        renditaRaddoppiata.Add(prezzo * 2);
                    }
                    return renditaRaddoppiata;
                }
               
            }

            set
            {
                _rendita = value;
            }
        }

        public string Colore
        {
            get
            {
                return _colore;
            }
            private set
            {
                _colore = value;
            }
        }

        public float CostoPerCasa
        {
            get
            {
                return _costoPerCasa;
            }
            private set
            {
                _costoPerCasa = value;
            }
        }

        public Pedina Proprietario
        {
            get
            {
                return _proprietario;
            }
            set
            {
                _proprietario = value;
            }
        }






    }
}