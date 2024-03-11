using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número maior que zero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0) 
            {
                Console.WriteLine("O numero precisa obrigatoriamente ser maior que zero. ");
                return;
            }
            else
            {
                int soma = 0;
                while (numero > 0)
                {
                    soma += numero % 10;
                    numero /= 10;

                    Console.WriteLine("A soma de todos algarismos é: " + soma);
                }
                Console.ReadLine();
            }
        }
    }
}
