using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("Opção 1");
            Console.WriteLine("Opção 2");
            Console.WriteLine("Opção 3");
            Console.WriteLine("Opção 4");
            Console.WriteLine("Opção 5");
            Console.WriteLine("Opção 6");
            Console.WriteLine("Opção 7");
            Console.WriteLine("Selecione uma das opções acima para ver em que dia da semana se encaixa: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Dia 1 é domingo!");
                    break;
                case 2:
                    Console.WriteLine("Dia 2 é segunda-feira!");
                    break;
                case 3:
                    Console.WriteLine("Dia 3 é terça-feira!");
                    break;
                case 4:
                    Console.WriteLine("Dia 4 é quarta-feira!");
                    break;
                case 5:
                    Console.WriteLine("Dia 5 é quinta-feira!");
                    break;
                case 6:
                    Console.WriteLine("Dia 6 é sexta-feira!");
                    break;
                case 7:
                    Console.WriteLine("Dia 7 é sabado!");
                    break;
                default:
                    Console.WriteLine("Seu número é inválido!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
