﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgettoMonopoly
{
    public class Strada : Proprieta
    {
        private Distretto _distretto;
        public Strada()
        {

        }

        public Distretto Distretto
        {
            get
            {
                return _distretto;
            }
            set
            {
                _distretto = value;
            }
        }

    }
}