using System;
using System.Collections.Generic;
using System.Text;

namespace Método_get_e_set
{
    public class Carro
    {
        private string Marca;
        private string Nome;
        private double Potência;

        //public Carro(string marca, string nome, double potêcncia)
        //{
        //    Marca = marca;
        //    Nome = nome;
        //    Potência = potêcncia;
        //}
        //public Carro()
        //{

        //}

        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
    }
}
