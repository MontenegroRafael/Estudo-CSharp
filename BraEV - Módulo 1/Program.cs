/* - “Digno és tu, Senhor e Deus nosso, de receber a glória, a honra e o poder, 
      pois foste tu que criaste o universo; por tua vontade, ele não era e foi criado." 

   - Apocalipse 4:11 .*/
using System;

namespace BraEV___Módulo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Olá Mundo!");
            //Comentarios.Comenta();
            //Variaveis.VariaveisExemplo();
            //Conversão.TiposConveção();
            //Formatação.TiposFormatação();
            //Operadores_Aritméticos.OpAritméticos();
            //Operadores_Relacionais.OpRelacionais();
            //Operadores_Lógicos.OpLógico();
            //Operadores_Unários.OpUnário();
            //Estruturas_de_Controle_if.EstruturaIf();
            //Estruturas_de_Controle_else.EstruturaElse();
            //Estruturas_de_Controle_Switch.EstruturaSwitch();
            //Estruturas_de_Controle_While.EstruturaWhile();
            //Estruturas_de_Controle_for.EstruturaFor();

            /*Trabalho 1
            Fazer programa que faça leitura de três notas de um determinado aluno e 
            fornecer para o professor a média das três notas, 
            indicando se o aluno está em recuperação ou aprovado. 
            Caso o aluno esteja em recuperação sua nota deverá ser menor que sete, 
            caso sua nota seja maior, o aluno é considerado aprovado.*/

            //float média = 0;

            //Console.WriteLine("----------- Calculo da Média ----------");

            //Console.WriteLine("Digite a 1° nota: ");
            //int.TryParse(Console.ReadLine(), out int nota1);

            //Console.WriteLine("Digite a 2° nota: ");
            //int.TryParse(Console.ReadLine(), out int nota2);

            //Console.WriteLine("Digite a 3° nota: ");
            //int.TryParse(Console.ReadLine(), out int nota3);

            //média = (nota1 + nota2 + nota3) / 3;

            //Console.WriteLine("A média do aluno é: {0}", média);

            //if (média < 7)
            //{
            //    Console.WriteLine("O aluno esta em recuperação");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno aprovado!");
            //}

            /* 
            Trabalho 2
            programa em que o usuário realizará diversas somas a partir de um número inicial e 
            de outros números fornecidos por ele. 
            O programa só será encerrado quando o usuário desejar.   */

            bool opção = true;
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o valor inicial");
            double inicial = Convert.ToDouble(Console.ReadLine());

            while (opção == true)
            {
                Console.WriteLine("Digite o némero que deseja somar ao número inicial");
                double n1 = Convert.ToDouble(Console.ReadLine());
                inicial = inicial + n1;
                Console.WriteLine("A soma até  momento é {0}", inicial);
                Console.WriteLine("Deseja sair do programa? 1 - sim 2 - não");
                int saída = Convert.ToInt32(Console.ReadLine());
                switch (saída)
                {
                    case 1:
                        Console.WriteLine("Saindo do Programa.");
                        opção = false;
                        break;
                    case 2:
                        Console.WriteLine("Continua a soma.");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida! Retornando para soma.");
                        break;
                }
            }
        }
    }
}
