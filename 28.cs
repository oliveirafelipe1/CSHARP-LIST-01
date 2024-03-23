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
            Console.WriteLine("Escolha uma das médias abaixo: ");
            Console.WriteLine("Opção 1 - Geometrica.");
            Console.WriteLine("Opçãp 2 - Ponderada.");
            Console.WriteLine("Opção 3 - Harmôminca.");
            Console.WriteLine("Opção 4 - Aritmética.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Digite o valor de X: ");
                double X = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Y: ");
                double Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Z: ");
                double Z = double.Parse(Console.ReadLine());

                double resultado = Math.Sqrt(X * Y * Z);
                Console.WriteLine("Resultado: " + resultado);
                
                break;
            
                case 2:
                Console.WriteLine("Digite o valor de X: ");
                X = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Y: ");
                Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Z: ");
                Z = double.Parse(Console.ReadLine());

                resultado = (X + 2 * Y + 3 * Z) / 6;
                Console.WriteLine("Resultado: " + resultado);
                
                break;
            
            
                case 3:
                Console.WriteLine("Digite o valor de X: ");
                X = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Y: ");
                Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Z: ");
                Z = double.Parse(Console.ReadLine());

                double reciproco1 = 1.0 / X;
                double reciproco2 = 1.0 / Y;
                double reciproco3 = 1.0 / Z;
                resultado = 3.0 / (reciproco1 + reciproco2 + reciproco3);
                Console.WriteLine("Resultado: " + resultado);
                
                break;

                case 4:
                Console.WriteLine("Digite o valor de X: ");
                X = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Y: ");
                Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de Z: ");
                Z = double.Parse(Console.ReadLine());

                resultado = (X + Y + Z) / 3;
                Console.WriteLine("Resultado: " + resultado);
                
                break;

                default:
                Console.WriteLine("Opção inválida!");
                
                break;
            }
        Console.ReadLine();
        }
    }
}