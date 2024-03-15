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
            int idade;
            double tempoDeTrabalho;

            Console.WriteLine("Qual sua idade? ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto tempo você trabalha? ");
            tempoDeTrabalho = double.Parse(Console.ReadLine());

            if (idade >= 65)
            {
                Console.WriteLine("Seus requisitos atendem às solicitações para a aposentadoria.");
            }
            else if (tempoDeTrabalho >= 30)
            {
                Console.WriteLine("Seus requisitos atendem às solicitações para a aposentadoria.");
            }
            else if (idade >= 60 && tempoDeTrabalho >= 25)
            {
                Console.WriteLine("Seus requisitos atendem às solicitações para a aposentadoria.");
            }
            else
            {
                Console.WriteLine("Seus requisitos não atendem às solicitações mínimas para a aposentadoria.");
            }
            Console.ReadLine();
        }
    }
}
