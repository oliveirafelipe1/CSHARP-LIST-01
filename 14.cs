using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Digite a nota da primeira prova? ");
                double trabalhoDeLaboratorio = double.Parse(Console.ReadLine());

                Console.Write("Digite a nota da segunda prova? ");
                double avaliacaoSemestral = double.Parse(Console.ReadLine());

                Console.Write("Digite a nota da terceira prova? ");
                double exameFinal = double.Parse(Console.ReadLine());

                double mediaPonderada1 = (2 * trabalhoDeLaboratorio) + (3 * avaliacaoSemestral) + (5 * exameFinal);
                double mediaPonderada2 = mediaPonderada1 / 10;

                if (mediaPonderada2 <= 2.9)
                {
                     Console.WriteLine("O aluno está reprovado, com uma média de " + mediaPonderada2);
                     return;
                }
                else if (mediaPonderada2 >= 3 && mediaPonderada2 <= 4.9)
                {
                    Console.WriteLine("O aluno está de recuperação, com uma média de " + mediaPonderada2);
                    return;
                }
                else
                {
                    Console.WriteLine("O aluno foi aprovado, com uma média de " + mediaPonderada2);
                }

            Console.ReadLine();
            }
        }
    }