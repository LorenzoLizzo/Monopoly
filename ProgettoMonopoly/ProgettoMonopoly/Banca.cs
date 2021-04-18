using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Banca
    {
        private float _denaro;
        public Banca(float denaro)
        {
            DenaroDellaBanca = denaro;
        }

        public float DenaroDellaBanca
        {
            get
            {
                return _denaro;
            }
            set
            {
                _denaro = value;
            }
        }

        public void VendiProprietaAPedina(Proprieta proprieta, Pedina pedina)
        {
            pedina.DenaroPedina -= proprieta.Prezzo;
            pedina.ListaProprieta.Add(proprieta);
        }

        public Pedina CalcolaVincitoreAsta(List<KeyValuePair<Pedina, float>> offerte)
        {
            Pedina pedina = offerte[0].Key;
            float massimo = 0;
            foreach(KeyValuePair<Pedina, float> offerta in offerte)
            {
                if(offerta.Value > massimo)
                {
                    massimo = offerta.Value;
                    pedina = offerta.Key;
                }
            }

            return pedina;


        }
    }
}