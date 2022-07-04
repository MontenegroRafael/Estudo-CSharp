using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    class Elementos_Estáticos
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
        // fica assim no Main()
        // ----Com 'static'
        //var result = Metodos.Multiplicar(3, 3); --- pode criar uma variável sem precisar estânciar
        //Console.WriteLine("A multiplicação é igual a: {0}", result);
        // ou
        //Console.WriteLine(Metodos.Multiplicar(3, 3)); -- pode tambem sem criar uma variável

        // ----Sem 'static'
        //Metodos calc = new Metodos(); -- desta forma precisa criar uma variável e estânciar
        //Console.WriteLine(calc.Somar(6, 4));
    }
}
