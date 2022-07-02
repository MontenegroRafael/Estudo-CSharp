using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Conversão
    {
        public static void TiposConveção()
        {
            int x = 4;
            int y = 6;
            double total = x + y; // Conversão Implícita
            Console.WriteLine(total);

            double nota = 8.6;
            int notaconvertida = (int)nota; // Conversão Explicita
            Console.WriteLine(notaconvertida);

            Console.WriteLine("Digite qual número é sua casa: ");
            string númeroCasa = Console.ReadLine();
            int número = int.Parse(númeroCasa);
            Console.WriteLine("Número da casa é: {0}", número);

            número = Convert.ToInt32(númeroCasa);

            Console.WriteLine(número);

            Console.WriteLine("Qual é o seu Nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            // int idade = Convert.ToInt32(Console.ReadLine()); // outro jeito de converter

            Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
        }
    }
}
