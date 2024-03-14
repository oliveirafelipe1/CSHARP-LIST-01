using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A do triângulo: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B do triângulo: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C do triângulo: ");
            double ladoC = double.Parse(Console.ReadLine());

            if (ladoA < ladoB + ladoC || ladoB < ladoA + ladoC || ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é equilátero, pois possui os três lados iguais.");
                }
                else if (ladoA == ladoB && ladoA != ladoC || ladoB == ladoC && ladoB != ladoA || ladoC == ladoA && ladoC != ladoB)
                {
                    Console.WriteLine("O triângulo é isósceles, pois possui dois lados iguais.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno, pois possui os três lados diferentes.");
                }
            }
            else
            {
                Console.WriteLine("O comprimento de cada lado de um triângulo deve ser menor do que a soma dos outros dois lados.");
            }
        Console.ReadLine();
        }
    }
}
