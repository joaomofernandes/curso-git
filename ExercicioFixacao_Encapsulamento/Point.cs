﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Encapsulamento
{
    struct Point
    {
        public double X, Y;

        public override string ToString()
        {
            return "("+ X + ", " + Y + ")";
        }
    }
}

