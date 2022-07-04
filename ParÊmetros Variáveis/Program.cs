using System;

namespace Parâmetros_Variáveis
{
    class Program
    {
        static void Main()
        {
            Despedida("João", "Thiago", "Pedro");
            
        }
        public static void Despedida(params string [] alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
            }
        }
    }
}
