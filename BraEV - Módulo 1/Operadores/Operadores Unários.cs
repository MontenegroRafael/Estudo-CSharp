using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Operadores_Unários
    {
        public static void OpUnário()
        {
            var x = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;
            Console.WriteLine("x = {0} quando negado fica {1}",x, !x); // nega o valor de x
            
            Console.WriteLine("n3 = {0} quando utiliza o incremento (++n3) fica {1}",n3, ++n3);
            // é o mesmo que n3 = n3 + 1; // incrementa +1 no valor de n3

            
            Console.WriteLine("n4 = {0} quando utiliza o decremento (--n4) fica {1}", n4, --n4);
            // é o mesmo que n4 = n4 - 1; // decrementa -1 no valor de n4
            
            // o programa executa nesse sentido na linha ========>>>>>>>
            Console.WriteLine("{0} é igual a ({1} - 1)? {2}",n2, n1, n2 == --n1);
            
            Console.WriteLine("({0} - 1) é igual a ({1} + 1)? {2}", n2, n1, n2-- == ++n1);

            // Importante
            int a = 100;
            /*
                a++ equivale a fazer a = a + 1;
                ++a també equivale a fazer a = a + 1;

                então qual é a diferença entre os dois?    */

            Console.WriteLine("------------------- Pos incremento --------------------");
            Console.WriteLine("Valor de 'a' na mesma linha do pos incremento(a++): {0}", a++); // retorna a = 100
            Console.WriteLine("Valor de 'a' na linha seguinte ao pos incremento(a++): {0}", a); // retorna a = 101

            Console.WriteLine("------------------- Pré incremento --------------------");
            Console.WriteLine("Valor de 'a' na mesma linha do pré incremento(++a): {0}", ++a); // retorna a = 102


        }
    }
}
