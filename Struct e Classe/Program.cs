using System;

namespace Struct_e_Classe
{
    public class Program
    {
        public struct PontoS
        {
            public int X;
            public int Y;
        }
        public class PontoC
        {
            public int X;
            public int Y;
        }
        public static void Main(string[] args)
        {
            PontoS ponto = new PontoS { X = 5, Y = 3 };
            PontoS ponto2 = ponto; // Copiar através do valor
            ponto.X = 3; 
            // por se tratar de uma Struct, mesmo alterando o valor de 'X' em 'ponto'
            // o valor de 'ponto2' mesmo sendo 'ponto2 = ponto' o valor de 'X' não altera.

            Console.WriteLine("Ponto: {0}", ponto.X);
            Console.WriteLine("Ponto 2: {0}", ponto2.X);

            PontoC ponto3 = new PontoC { X = 6, Y = 9 };
            PontoC ponto4 = ponto3;
            ponto3.X = 3;
            // no caso da 'Classe' já autera por que as atribuições podem ser feitas por referência.
            

            Console.WriteLine($"Ponto 3 = {ponto3.X} , Ponto 4 = {ponto4.X}");
        }
    }
}
