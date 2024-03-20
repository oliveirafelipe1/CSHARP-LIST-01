using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao; double resultado;

            Console.WriteLine("Agora escolha uma das médias abaixo: ");
            Console.WriteLine("Opção 1 - Geométrica");
            Console.WriteLine("Opção 2 - Ponderada");
            Console.WriteLine("Opção 3 - Harmônica");
            Console.WriteLine("Opção 4 - Aritmética");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro positivo: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro positivo: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um número inteiro positivo: ");
            int z = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    resultado = Math.Pow(x * y * z, 1.0 / 3.0);
                    
                    Console.WriteLine("A média geométrica deu: " + resultado);
                    break;
                case 2:
                    resultado = (x + 2 * y + 3 * z) / 6;

                    Console.WriteLine("A média ponderada deu: " + resultado);
                    break;
                case 3:
                    
                    // resolver isso!!!

                    break;
                case 4:
                    resultado = (x + y + z) / 3;

                    Console.WriteLine("A média aritmética deu: " + resultado);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        Console.ReadLine();
        }
    }
}
