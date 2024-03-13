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
            Console.WriteLine("Opção 8");
            Console.WriteLine("Opção 9");
            Console.WriteLine("Opção 10");
            Console.WriteLine("Opção 11");
            Console.WriteLine("Opção 12");
            Console.WriteLine("Selecione uma das opções acima para ver em que mês do ano se encaixa: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Mês 1 é janeiro!");
                    break;
                case 2:
                    Console.WriteLine("Mês 2 é fevereiro!");
                    break;
                case 3:
                    Console.WriteLine("Mês 3 é março!");
                    break;
                case 4:
                    Console.WriteLine("Mês 4 é abril!");
                    break;
                case 5:
                    Console.WriteLine("Mês 5 é maio!");
                    break;
                case 6:
                    Console.WriteLine("Mês 6 é junho!");
                    break;
                case 7:
                    Console.WriteLine("Mês 7 é julho!");
                    break;
                case 8:
                    Console.WriteLine("Mês 8 é agosto!");
                    break;
                case 9:
                    Console.WriteLine("Mês 9 é setembro!");
                    break;
                case 10:
                    Console.WriteLine("Mês 10 é outubro!");
                    break;
                case 11:
                    Console.WriteLine("Mês 11 é novembro!");
                    break;
                case 12:
                    Console.WriteLine("Mês 12 é dezembro!");
                    break;
                default:
                    Console.WriteLine("Seu número é inválido!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
