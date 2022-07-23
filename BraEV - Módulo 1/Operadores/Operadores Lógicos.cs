using System;
using System.Collections.Generic;
using System.Text;

namespace BraEV___Módulo_1
{
    public class Operadores_Lógicos
    {
        public static void OpLógico()
        {
            var atividade1 = true;
            var atividade2 = false;

            var todas = atividade1 && atividade2;

            Console.WriteLine("Fez todas as atividades ? {0}", todas);

            var umaApenas = atividade1 || atividade2;

            Console.WriteLine("Fez pelo menos uma das atividades ? {0}", umaApenas);
            Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);
        }
    }
}
