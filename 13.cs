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
            double prova1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova? ");
            double prova2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da terceira prova? ");
            double prova3 = double.Parse(Console.ReadLine());

            double mediaPonderada1 = (1 * prova1) + (1 * prova2) + (2 * prova3);
            double mediaPonderada2 = mediaPonderada1 / 4;

            if (mediaPonderada2 >= 60)
            {
                Console.WriteLine("O aluno foi aprovado, com uma média de " + mediaPonderada2);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado, com uma média de " + mediaPonderada2);
            }
            Console.ReadLine();
        }
    }
}
