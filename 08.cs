using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga a nota do primeiro aluno: ");
            double notaAluno1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Diga a nota do outro aluno: ");
            double notaAluno2 = double.Parse(Console.ReadLine());

            if (notaAluno1 >= 0 && notaAluno2 >= 0 && notaAluno1 <= 10 && notaAluno2 <= 10)
            {
                double mediaAritmetica = (notaAluno1 + notaAluno2) / 2;
                Console.WriteLine("A média dessas notas é: " + mediaAritmetica);
            }
            else
            {
                Console.WriteLine("A nota de um ou mais alunos não é válida. ");
            }
            Console.ReadLine();
        }
    }
}
