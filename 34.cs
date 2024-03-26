using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a nota do aluno? ");
            double nota = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas faltas ele tem? ");
            double faltas = double.Parse(Console.ReadLine());

            if (nota >= 9.0 && nota <= 10.0)
            {
                if (faltas >= 0 && faltas <= 20)
                {
                    Console.WriteLine("A!");
                }
                else if (faltas > 20)
                {
                    Console.WriteLine("B!");
                }
                else
                {
                    Console.WriteLine("Faltas inválidas!");
                }
            }
            else if (nota >= 7.5 && nota <= 8.9)
            {
                if (faltas >= 0 && faltas <= 20)
                {
                    Console.WriteLine("B!");
                }
                else if (faltas > 20)
                {
                    Console.WriteLine("C!");
                }
                else
                {
                    Console.WriteLine("Faltas inválidas!");
                }
            }
            else if (nota >= 5.0 && nota <= 7.4)
            {
                if (faltas >= 0 && faltas <= 20)
                {
                    Console.WriteLine("C!");
                }
                else if (faltas > 20)
                {
                    Console.WriteLine("D!");
                }
                else
                {
                    Console.WriteLine("Faltas inválidas!");
                }
            }
            else if (nota >= 4.0 && nota <= 4.9)
            {
                if (faltas >= 0 && faltas <= 20)
                {
                    Console.WriteLine("D!");
                }
                else if (faltas > 20)
                {
                    Console.WriteLine("E!");
                }
                else
                {
                    Console.WriteLine("Faltas inválidas!");
                }
            }
            else if (nota >= 0.0 && nota <= 3.9)
            {
                if (faltas >= 0 && faltas <= 20)
                {
                    Console.WriteLine("E!");
                }
                else if (faltas > 20)
                {
                    Console.WriteLine("E!");
                }
                else
                {
                    Console.WriteLine("Faltas inválidas!");
                }
            }
            else
            {
                Console.WriteLine("Nota inválida!");
            }
            Console.ReadLine();
        }
    }
}
