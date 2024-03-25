using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            double numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um número: ");
            double numero3 = int.Parse(Console.ReadLine());

            double temp;

            if (numero1 > numero2)
            {
                temp = numero1;
                numero1 = numero2;
                numero2 = temp;
            }
            if (numero2 > numero3)
            {
                temp = numero2;
                numero2 = numero3;
                numero3 = temp;

                if (numero1 > numero2)
                {
                    temp = numero1;
                    numero1 = numero2;
                    numero2 = temp;
                }
            }
            Console.WriteLine($"Na ordem crescente fica: {numero1}, {numero2} e {numero3}.");

            Console.ReadLine();
        }
    }
}
