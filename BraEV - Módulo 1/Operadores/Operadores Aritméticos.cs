using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Operadores_Aritméticos
    {
        public static void OpAritméticos()
        {
            var soma = 4 + 3;
            var subtração = 4 - 3;
            var multiplicação = 4 * 3;
            var divisão = 4 / 3;
            var expoente = Math.Pow(4, 2); // 4^2(quatro elevado a dois)
            var resto = 4 % 2;
            Console.WriteLine("Soma=> 4 + 3 = {0}", soma);
            Console.WriteLine("Subtração=> 4 - 3 = {0}", subtração);
            Console.WriteLine("Multiplicação=> 4 * 3 = {0}", multiplicação);
            Console.WriteLine("Divisão=> 4 / 3 = {0}", divisão);
            Console.WriteLine("Resto=> 4 / 2 o resto é = {0}", resto);
            Console.WriteLine("Expoente+> 4^2 = {0}", expoente);

            

        }
    }
}
