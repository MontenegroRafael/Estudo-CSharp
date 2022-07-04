using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Metodos
    {
        // Atributos
        public string Nome;
        public int Idade;
        public int Serie;
        public static float Multiplicar(float x, float y) // com static. sem a nessecidade de estânciar
        {
            
            return x * y;
        }
        public float Somar(float x, float y) // sem static. tem a necessidade de estânciar
        {
            var a = x + y;
            return a;
        }
        public string Retorno()
        {
            return string.Format($"O aluno {Nome} tem {Idade} anos e pertence a série {Serie}");
        }
        public void RetornoConsole()
        {
            Console.WriteLine(Retorno());
        }
    }
}
