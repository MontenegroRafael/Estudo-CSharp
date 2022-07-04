using System;

namespace Método_get_e_set
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro carro1 = new Carro("Ford", "Fusion", 2.0);
            Carro carro1 = new Carro();
            
            //Console.WriteLine($"{ carro1.GetMarca()}");
            carro1.SetMarca("Volvo");
            Console.WriteLine(carro1.GetMarca());
        }
    }
}
