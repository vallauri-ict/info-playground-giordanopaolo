﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Ereditarietà
{
    class Mostro
    {
        protected double punti;
        protected string verso;
        public Mostro()
        {
            punti = 25;
            verso = "grugnito";
        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
