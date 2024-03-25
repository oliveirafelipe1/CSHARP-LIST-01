using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço antigo do seu produto: ");
            double produto = double.Parse(Console.ReadLine());

            double resultado = 0;

            if (produto < 50)
            {
                resultado = produto + produto * 5 / 100;
                Console.WriteLine("O preço novo do seu produto é: " + resultado);
            }
            else if (produto >= 50 && produto <= 100)
            {
                resultado = produto + produto * 10 / 100;
                Console.WriteLine("O preço novo do seu produto é: " + resultado);
            }
            else if (produto > 100)
            {
                resultado = produto + produto * 15 / 100;
                Console.WriteLine("O preço novo do seu produto é: " + resultado);
            }
            else
            {
                Console.WriteLine("Preço inválido!");
            }
            Console.ReadLine();
        }
    }
}
