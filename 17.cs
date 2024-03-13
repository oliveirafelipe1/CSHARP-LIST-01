using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float areaTrapezio;

            Console.WriteLine("Digite o valor da base menor: ");
            float baseMenor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da base maior: ");
            float baseMaior= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");
            float altura = float.Parse(Console.ReadLine());

            float resultado1 = (baseMaior + baseMenor) * altura;
            areaTrapezio = resultado1 / 2;

            if (baseMenor > 0 && baseMaior > 0)
            {
                Console.WriteLine("O valor da área do seu trapezio é de: " + areaTrapezio + "m²");
            }
            else
            {
                Console.WriteLine("O seu trapezio precisa de bases com um valor maior que zero.");
            }
            Console.ReadLine();
        }
    }
}
