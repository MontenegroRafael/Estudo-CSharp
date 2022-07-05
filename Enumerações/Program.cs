using System;

namespace Enumerações
{
    public class Program
    {
        public enum Genero
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
            int cod = (int)Genero.Serie; // convertendo string em 'int'
            Console.WriteLine("A posição do item Serie é: ",cod);
        }
    }
}
