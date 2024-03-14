using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if ((numero % 3 == 0 || numero % 5 == 0) && !(numero % 3 == 0 && numero % 5 == 0))
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine($"{numero} é divisível por 3, mas não por 5.");
                }
                else
                {
                    Console.WriteLine($"{numero} é divisível por 5, mas não por 3.");
                }
            }
            else
            {
                Console.WriteLine($"{numero} não é divisível por ambos, ou é pelos dois.");
            }
            Console.ReadLine();
        }
    }
}
