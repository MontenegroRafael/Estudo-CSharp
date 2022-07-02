using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Operadores_Relacionais
    {
        public static void OpRelacionais()
        {
            double nota1 = 8.0;
            double nota2 = 9.0;

            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);
            Console.WriteLine("A nota 2 é maior que a nota 1 ? {0}", nota2 > nota1);

            Console.WriteLine("Digite sua nota: ");
            //double.TryParse(Console.ReadLine(), out double nota);
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota == 10.0);
        }
    }
}
