using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero real: ");
            int numeroReal = int.Parse(Console.ReadLine());

            if (numeroReal >= 0)
            {
                double resultado1 = Math.Sqrt(numeroReal);
                Console.WriteLine("A raiz quadrada do seu número é: " + resultado1);
            }
            else
            {
                double resultado2 = numeroReal * numeroReal;
                Console.WriteLine("O seu numero elevado a ele mesmo da: " + resultado2);
            }
            Console.ReadLine();
        }
    }
}
