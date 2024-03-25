using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao restaurante, escolha um dos lanches digitando o código.");
            Console.WriteLine("Código 100 - Cachorro Quente");
            Console.WriteLine("Código 101 - Bauru Simples");
            Console.WriteLine("Código 102 - Bauru com Ovo");
            Console.WriteLine("Código 103 - Hamburguer");
            Console.WriteLine("Código 104 - Cheeseburguer");
            Console.WriteLine("Código 105 - Suco");
            Console.WriteLine("Código 106 - Refrigerante");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos vai querer levar? ");
            double vezes = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 100:
                    resultado = 1.20 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 101:
                    resultado = 1.30 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 102:
                    resultado = 1.50 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 103:
                    resultado = 1.20 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 104:
                    resultado = 1.70 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 105:
                    resultado = 2.20 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                case 106:
                    resultado = 1.00 * vezes;
                    Console.WriteLine($"{resultado}" + "R$");
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }
        }
    }
}
