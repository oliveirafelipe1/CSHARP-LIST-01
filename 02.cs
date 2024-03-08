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
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                double resultado = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrada do seu número é: " + resultado);
            }
            else
            {
                Console.WriteLine("O seu número é inválido.");
            }
            Console.ReadLine();
        }
    }
}
