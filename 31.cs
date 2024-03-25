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
            Console.WriteLine("Qual usa altura? (em metros) ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu peso? ");
            double peso = double.Parse(Console.ReadLine());

            if (altura <= 1.20)
            {
                if (peso <= 60)
                {
                    Console.WriteLine("A!");
                }
                else if (peso <= 90)
                {
                    Console.WriteLine("D!");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("G!");
                }
            }
            else if (altura >= 1.20 && altura <= 1.70)
            {
                if (peso <= 60)
                {
                    Console.WriteLine("B!");
                }
                else if (peso <= 90)
                {
                    Console.WriteLine("E!");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("H!");
                }
            }
            else if (altura > 1.70)
            {
                if (peso <= 60)
                {
                    Console.WriteLine("C!");
                }
                else if (peso <= 90)
                {
                    Console.WriteLine("F!");
                }
                else if (peso > 90)
                {
                    Console.WriteLine("I!");
                }
            }
            else
            {
                Console.WriteLine("Idade ou peso inválidos!");
            }
            Console.ReadLine();
        }
    }
}