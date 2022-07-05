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

            Console.WriteLine("Ponto: {0}", ponto.X);
            Console.WriteLine("Ponto 2: {0}", ponto.X);

            PontoC ponto3 = new PontoC { X = 6, Y = 9 };
            PontoC ponto4 = ponto3;
            ponto3.X = 3;

            Console.WriteLine("Ponto 3 = {0} , Ponto 4 = {1}", ponto3, ponto4);
        }
    }
}
