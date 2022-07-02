using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Formatação
    {
        public static void TiposFormatação()
        {
            double x = 20.232;
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));

            var salário = 1285.76;
            var idade = 35;
            Console.WriteLine("Idade {0}, Salário {1}", idade, salário);

        }
    }
}
