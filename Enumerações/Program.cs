using System;
using System.Collections.Generic;

namespace Enumerações
{
    public class Program
    {
        public enum Genero // todas as atribuições serão enumeradas. 'Filme' recebe 0, 'Serie' recebe 1 e assim por diante.
        {
            Filme,
            Serie,
            Documentário
        }
        public class Filme
        {
            public string Nome;
            public Genero TipoVideo;
        }
        static void Main(string[] args)
        {
            int cod = (int)Genero.Documentário; // convertendo string em 'int'
            Console.WriteLine($"A posição do item é:{cod}");
            Console.WriteLine("A posição do item é: " + cod);
            Console.WriteLine(cod);
        }
    }
}
