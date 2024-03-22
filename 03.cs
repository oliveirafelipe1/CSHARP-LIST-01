using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tipo de habilitação que vc tem? ");
            char habilitacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Quanto tempo você tem possui a carteira de habilitação? (em anos) ");
            double tempo = int.Parse(Console.ReadLine());

                if (idade < 21)
                {
                    Console.Write("Idade mínima nao comprida.");
                }
                else if ((tempo < 2) && (habilitacao == 'B' || habilitacao == 'b'))
                {
                    Console.WriteLine("Tempo mínimo de habilitação B não comprido.");
                }
                else if ((tempo < 1) && (habilitacao == 'C' || habilitacao == 'c'))
                {
                    Console.WriteLine("Tempo mínimo de habilitação C não comprido.");
                }
                else
                {
                    Console.WriteLine("Voce possui os requisitos para carteira D.");
                }
            Console.ReadLine();
        }
    }
}
