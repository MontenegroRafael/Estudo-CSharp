using System;

namespace Parâmetros_por_Referência
{
    class Program
    {
        public static void AlterarRef(ref int numero) // este meto altera o valor da referência.
        {
            numero += 500;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 50;
        }
        static void Main(string[] args)
        {
            int x = 5;
            AlterarRef(ref x); // utilizando o valor original de 'x' será alterado permanentemente.
            Console.WriteLine(x);

            var soma = x + 100; // 'x' aqui já tem  novo valor de 505. 
            Console.WriteLine(soma);

            int y = 8;
            AlterarOut(out y); // aqui você usa o metodo para alterar o valor original de 'y' durante a execução.
            Console.WriteLine(y);
        }
    }
}
