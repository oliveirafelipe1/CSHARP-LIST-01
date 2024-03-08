using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Digite um número inteiro: ");
                int numeroInteiro1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro número inteiro: ");
                int numeroInteiro2 = int.Parse(Console.ReadLine());

                int diferenca = numeroInteiro1 - numeroInteiro2;

                if (numeroInteiro1 > numeroInteiro2)
                {
                    Console.WriteLine($"O {numeroInteiro1} é maior que o {numeroInteiro2}");
                }
                else if (numeroInteiro2 > numeroInteiro1)
                {
                    Console.WriteLine($"O {numeroInteiro2} é maior que o {numeroInteiro1}");
                }
                else
                {
                    Console.WriteLine("Os dois número são iguais.");
                }
                Console.ReadLine();
            }
        }
    }
