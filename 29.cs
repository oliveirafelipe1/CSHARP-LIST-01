using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int x = 1;
            Random rnd = new Random();

            Console.WriteLine("Bem-vindo a prova! Responda as questões a seguir: ");

            while (x > 0 && x < 6)
            {
                int a = rnd.Next(1, 100);
                int b = rnd.Next(1, 100);

                Console.WriteLine($"Qual a soma de {a} + {b}? ");
                int resposta = int.Parse(Console.ReadLine());

                int resultado = a + b;

                x++;

                if (resultado == resposta)
                {
                    ++score;
                }
            }
            Console.WriteLine($"Você teve o total de {score} acertos!");

            Console.ReadLine();
        }
    }
}
