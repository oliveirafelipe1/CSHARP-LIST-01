using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as raízes da sua equação de segundo grau: (ax² + bx + c = 0)");
            
            Console.WriteLine("a = ");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("c = ");
            double c = int.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("Não existe raíz.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"{x1}, raíz única.");
            } 
            else if (delta >= 0)
            {
                Console.WriteLine($"Duas raízes; {x1} e {x2}, sendo respectivamente x1 e x2.");
            }
            Console.ReadLine();
        }
    }
}
