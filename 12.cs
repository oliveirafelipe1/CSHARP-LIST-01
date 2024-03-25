using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0) 
            {
                Console.WriteLine("O seu numero precisa ser maior que zero.");
            }
            else
            {
                double soma = Math.Log10(numero);
                Console.WriteLine("O logaritmo do seu número é de: " + soma);
            }
            Console.ReadLine();
        }
    }
}
