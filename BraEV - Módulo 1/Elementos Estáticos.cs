﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Elementos_Estásticos
    {
        public static float Multiplicar(float x, float y) // com static. sem a nessecidade de estânciar
        {
            return x * y;
        }
        public float Somar(float x, float y) // sem static. tem a necessidade de estânciar
        {
            var a = x + y;
            return a;
        }
        
    }
}
