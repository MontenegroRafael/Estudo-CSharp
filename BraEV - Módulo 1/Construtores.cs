using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Construtores
    {
        // Atributos
        public string Nome;
        public string Marca;
        public double Potência;

        // Construtor
        public Construtores(string nome, string marca, double potência)
        {
            Nome = nome;
            Marca = marca;
            Potência = potência;
        }
        public Construtores()
        {

        }
    }
}
