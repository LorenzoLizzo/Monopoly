﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Pedina
    {
        private int _posizione;
        private float _denaroPedina;
        private List<Proprieta> _listaProprieta;
        private List<Proprieta> _listaProprietaIpotecate;

        public Pedina(float denaro)
        {
            Posizione = 0;
        }
        public int Posizione
        {
            get
            {
                return _posizione;
            }
            set
            {
                _posizione = value;
            }
        }

        public float DenaroPedina
        {
            get
            {
                return _denaroPedina;
            }
            set
            {
                _denaroPedina = value;
                if (Fallisci())
                    throw new Exception("il giocatore ha fallito");
            }
        }

        public List<Proprieta> ProprietaIpotecate
        {
            get
            {
                return _listaProprietaIpotecate;
            }
            set
            {
                _listaProprietaIpotecate = value;
            }
        }

        public List<Proprieta> ProprietaCheIlGiocatorePossiede
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

        public bool Fallisci()
        {
            if (DenaroPedina < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public int Giocata(int dado1, int dado2)
        {
            Posizione += dado1 + dado2;
            if(Posizione > 40)
            {
                Posizione -= 40;
            }
            return Posizione;
        }

        public void CompraProprieta(Banca banca, Proprieta proprieta)
        {
            DenaroPedina -= proprieta.Prezzo;
            _listaProprieta.Add(proprieta);
        }

        public void Ipoteca(Proprieta proprieta)
        {
            
        }
    }
}