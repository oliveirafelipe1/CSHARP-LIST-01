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
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                double numeroAoQuadrado = numero * numero;
                double raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine($"O seu numero ao quadrado é {numeroAoQuadrado} e a raíz {raizQuadrada}. ");
            }
            else
            {
                Console.WriteLine("Seu número precisa ser positivo. ");
            }
            Console.ReadLine();
        }
    }
}
