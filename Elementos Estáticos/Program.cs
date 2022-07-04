using System;

namespace Elementos_Estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ----Com 'static'
            var result = MetodosEstaticos.Multiplicar(3, 3); // ---pode criar uma variável sem precisar estânciar
            Console.WriteLine("A multiplicação é igual a: {0}", result);
            // ou
            Console.WriteLine(MetodosEstaticos.Multiplicar(3, 3)); // --pode tambem sem criar uma variável

            // ----Sem 'static'
            MetodosEstaticos calc = new MetodosEstaticos(); // --desta forma precisa criar uma variável e estânciar
            Console.WriteLine(calc.Somar(6, 4));
        }
    }
}
