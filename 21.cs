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
            int opcao;

            Console.WriteLine("Opção 1 - Soma de 2 números");
            Console.WriteLine("Opção 2 - Diferença entre 2 números (maior pelo menor)");
            Console.WriteLine("Opção 3 - Produto entre 2 números");
            Console.WriteLine("Opção 4 - Divisão entre 2 números (denominador não pode ser zero)");
            Console.WriteLine("Escolha uma das opções acima: ");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o primeiro número da operação: (numerador no caso da divisão) ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o primeiro número da operação: (denominaor no caso da divisão) ");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado;

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("O resultado da sua soma foi: " + resultado);
                    break;
                case 2:
                    if (numero1 > numero2)
                    {
                        resultado = numero1 - numero2;
                        Console.WriteLine("O resultado da sua dierença foi: " + resultado);
                        break;
                    }
                    else
                    {
                        resultado = numero2 - numero1;
                        Console.WriteLine("O resultado da sua dierença foi: " + resultado);
                        break;
                    }
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("O produto entre os dois números foi: " + resultado);
                    break;
                case 4:
                    if (numero2 <= 0)
                    {
                        Console.WriteLine("O denominador precisa ser maior que zero.");
                        break;
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("O resultado da divisão foi: " + resultado);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sua opção é inválida!");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
