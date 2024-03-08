using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu sálario? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da prestação de um empréstimo? ");
            double prestacaoEmprestimo = double.Parse(Console.ReadLine());

            double vintePorcento = salario / 100 * 20;

            if (prestacaoEmprestimo > vintePorcento)
            {
                Console.WriteLine("Empréstimo não concedido. ");
            }
            else
            {
                Console.WriteLine("Empréstimo concedido. ");
            }
            Console.ReadLine();
        }
    }
}
