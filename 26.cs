using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a distância percorrida em Km? ");
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos litros de gasolina foram consumidos? ");
            double gasolina = double.Parse(Console.ReadLine());

            double kmL = km / gasolina;

            if (kmL < 8)
            {
                Console.WriteLine("Venda o carro!");
            }
            else if (kmL >= 8 &&  kmL <= 14)
            {
                Console.WriteLine("Econômico!");
            }
            else if (kmL > 12)
            {
                Console.WriteLine("Super econômico!");
            }
        Console.ReadLine();
        }
    }
}
