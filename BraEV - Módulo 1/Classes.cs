using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Classes
    {
        // Construtor que não recebe argumentos:
        public Classes()
        {
            Name = "unknown";
        }

        // Construtor que recebe um argumento:
        public Classes(string name)
        {
            Name = name;
        }

        // Propriedade somente leitura implementada automaticamente:
        public string Name { get; }

        // Método que substitui a implementação da classe base (System.Object).
        public override string ToString()
        {
            return Name;
        }
    }
}
