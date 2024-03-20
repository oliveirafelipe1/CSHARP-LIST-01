using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a idade do nadador? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Seu nadador se encaixa na classe Infantil A.");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Seu nadador se encaixa na classe Infantil B.");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Seu nadador se encaixa na classe Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Seu nadador se encaixa na classe Juvenil B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Seu nadador se encaixa na classe Sênior.");
            }
            else
            {
                Console.WriteLine("Idade não classificada!");
            }
        Console.ReadLine();
        }
    }
}
