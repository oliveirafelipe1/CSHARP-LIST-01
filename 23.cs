using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            double resultado400 = ano % 400;
            double resultado4 = ano % 4;
            double resultado100 = ano % 100;

            if (resultado400 == 0)
            {
                if (resultado100 == 0)
                {
                    Console.WriteLine($"Seu ano de {ano} não é bissexto!");
                }
                else
                {
                    Console.WriteLine($"Seu ano de {ano} é bisssexto!");
                }
            }
            else if (resultado4 == 0)
            {
                if (resultado100 == 0)
                {
                    Console.WriteLine($"Seu ano de {ano} não é bissexto!");
                }
                else
                {
                    Console.WriteLine($"Seu ano de {ano} é bisssexto!");
                }
            }
            else if (ano > 0)
            {
                Console.WriteLine($"Seu ano de {ano} não é bissexto!");
            }
            else
            {
                Console.WriteLine("Resposta inválida!");
            }
            Console.ReadLine();
        }
    }
}
