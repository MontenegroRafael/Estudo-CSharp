using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Estruturas_de_Controle_if
    {
        public static void EstruturaIf()
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2)
            {
                Console.WriteLine(n1 + n2);
            }
            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }
        }
    }
}
