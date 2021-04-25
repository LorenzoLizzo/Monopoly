using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ProgettoMonopoly
{
    public class Banca : Pedina
    {
        private float _denaro;
        private ObservableCollection<Proprieta> _listaProprieta;
        public Banca()
        {
            
        }

        public float DenaroBanca
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

        public ObservableCollection<Proprieta> ListaProprietaBanca
        {
            get
            {
                return _listaProprieta;
            }
            set
            {
                _listaProprieta = value;
            }
        }

        public void DistribuisciDenaroIniziale(Pedina pedina)
        {
            pedina.DenaroPedina = 1500;
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