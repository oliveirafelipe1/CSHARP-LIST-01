using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            double resultado = numero % 2;

            if (resultado == 0)
            {
                Console.WriteLine("Seu número é par! ");
            }
            else
            {
                Console.WriteLine("Seu número é impar! ");
            }
            Console.ReadLine();
        }
    }
}
