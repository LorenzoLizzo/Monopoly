using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Pedina : IEquatable<Pedina>
    {
        private string _nome;
        private string _percorsoImmagine;
        private List<Proprieta> _listaProprieta;
        private Casella _posizione;
        private bool _pedinaInPrigione;
        private float _denaroPedina;
        private List<Proprieta> _listaProprietaIpotecate;

        public Pedina(float denaro)
        {
            PedinaInPrigione = false;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
            set
            {
                _percorsoImmagine = value;
            }
        }

        public List<Proprieta> ListaProprieta
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

        public Casella Posizione
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

        public bool PedinaInPrigione
        {
            get
            {
                return _pedinaInPrigione;
            }
            set
            {
                _pedinaInPrigione = value;
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

        /*
        public void PagaRendita(Proprieta proprieta, Pedina pedina)
        {
            if(proprieta is Terreno || proprieta is Casa || proprieta is Albergo)
            {
                if(proprieta is Terreno)
                {
                    this.DenaroPedina -= (proprieta as Terreno).Rendita[(proprieta as Terreno).LivelloProprieta];
                    pedina.DenaroPedina += (proprieta as Terreno).Rendita[(proprieta as Terreno).LivelloProprieta];
                }
                else if(proprieta is Casa)
                {
                    this.DenaroPedina -= (proprieta as Casa).Rendita[(proprieta as Casa).LivelloProprieta];
                    pedina.DenaroPedina += (proprieta as Casa).Rendita[(proprieta as Casa).LivelloProprieta];
                }
                else
                {
                    this.DenaroPedina -= (proprieta as Albergo).Rendita[(proprieta as Albergo).LivelloProprieta];
                    pedina.DenaroPedina += (proprieta as Albergo).Rendita[(proprieta as Albergo).LivelloProprieta];
                }
            }
            else
            {
                this.DenaroPedina -= proprieta.Rendita[0];
                pedina.DenaroPedina += proprieta.Rendita[0];
            }
            
        }
        
        public void MiglioraProprieta()
        {
            foreach(Proprieta proprieta in ListaProprieta)
            {
                if((proprieta is Terreno || proprieta is Casa) && proprieta.Numerocasella == this.Posizione)
                {
                    if (proprieta is Terreno)
                    {
                        (proprieta as Terreno).LivelloProprieta++;
                    }
                    else if (proprieta is Casa)
                    {
                        (proprieta as Casa).LivelloProprieta++;
                    }
                    break;
                }

                
            }
        }
        */
        //da fare ipoteca e derivanti
        public void Ipoteca(Proprieta proprieta)
        {
            //da fare
        }

        public bool Equals(Pedina other)
        {
            if(this.Nome == other.Nome)
            {
                return true;
            }
            return false;
        }
    }
}