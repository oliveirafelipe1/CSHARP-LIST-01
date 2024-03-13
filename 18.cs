using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao;

            Console.WriteLine("Opção 1 - '+' ");
            Console.WriteLine("Opção 2 - '-' ");
            Console.WriteLine("Opção 3 - '*' ");
            Console.WriteLine("Opção 4 - '/' ");
            Console.WriteLine("Selecione uma das operações matemática acima: ");
            operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o primeiro componente da operação: ");
            double componente1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o primeiro componente da operação: ");
            double componente2 = double.Parse(Console.ReadLine());

            double resultado;

            switch (operacao)
            {
                case 1:
                    resultado = componente1 + componente2;
                    Console.WriteLine("O resultado da sua adição deu: " + resultado);
                    break;
                case 2:
                    resultado = componente1 - componente2;
                    Console.WriteLine("O resultado da sua subtração deu: " + resultado);
                    break;
                case 3:
                    resultado = componente1 * componente2;
                    Console.WriteLine("O resultado do seu produto deu: " + resultado);
                    break;
                case 4:
                    resultado = componente1 / componente2;
                    Console.WriteLine("O resultado da sua divisão deu: " + resultado);
                    break;
                default:
                    Console.WriteLine("Sua opção é inválida!");
                    break;
            }
        Console.ReadLine();
        }
    }
}
