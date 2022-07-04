using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Estruturas_de_Controle_else
    {
        public static void EstruturaElse()
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2)
            {
                Console.WriteLine("Condição 1 é satisfeita !!");
                Console.WriteLine("Resultado da soma é {0}", n1 + n2);

            }
            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }
            else
            {
                Console.WriteLine("Condição 2 não é satisfeita!!");
            }
        }
    }
}
