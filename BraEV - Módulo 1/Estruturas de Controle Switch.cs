using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Estruturas_de_Controle_Switch
    {
        public static void EstruturaSwitch()
        {
            Console.WriteLine("Qual a nota você dar para o prato? 0, 5, ou 10");
            int.TryParse(Console.ReadLine(), out int nota);
            // nota = Convert.ToInt32(Console.ReadLine()); // poser ser desse jeito também

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Comida muito ruim!");
                    break;
                case 5:
                    Console.WriteLine("Comida razóavel.");
                    break;
                case 10:
                    Console.WriteLine("Comida muito boa!");
                    break;
                default:
                    Console.WriteLine("Nota inexistente!");
                    break;
            }
        }
    }
}
