using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int estado;
            double valorProduto;

            Console.WriteLine("Opção 1 - 'MG' ");
            Console.WriteLine("Opção 2 - 'SP' ");
            Console.WriteLine("Opção 3 - 'RJ' ");
            Console.WriteLine("Opção 4 - 'MS' ");
            Console.WriteLine("Selecione uma dos estados acima: ");
            estado = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do produto? ");
            valorProduto = double.Parse(Console.ReadLine());

            double comJuros;

            switch (estado)
            {
                case 1:
                    comJuros = valorProduto + valorProduto * 7 / 100;
                    Console.WriteLine("O seu produto com juros de MG ficou no valor de: " + comJuros + "R$");
                    break;
                case 2:
                    comJuros = valorProduto + valorProduto * 12 / 100;
                    Console.WriteLine("O seu produto com juros de SP ficou no valor de: " + comJuros + "R$");
                    break;
                case 3:
                    comJuros = valorProduto + valorProduto * 15 / 100;
                    Console.WriteLine("O seu produto com juros de RJ ficou no valor de: " + comJuros + "R$");
                    break;
                case 4:
                    comJuros = valorProduto + valorProduto * 8 / 100;
                    Console.WriteLine("O seu produto com juros de MS ficou no valor de: " + comJuros + "R$");
                    break;
                default:
                    Console.WriteLine("Seu estado não está entre os disponíveis.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
