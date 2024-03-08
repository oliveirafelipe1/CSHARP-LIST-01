using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine($"O {numero1} é maior que o {numero2}");

            else if (numero2 > numero1)
                Console.WriteLine($"O {numero2} é maior que o {numero1}");

            else
                Console.WriteLine("Os dois número são iguais.");

            Console.ReadLine();
        }
    }
}
