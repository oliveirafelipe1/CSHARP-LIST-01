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
            Console.WriteLine("Qual seu sexo? ('F' para Feminino / 'M' para Masculino)");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Quanto você mede de altura? (em metros) ");
            double altura = double.Parse(Console.ReadLine());

            double pesoIdealHomem = (72.7 * altura) - 58;
            double pesoIdealMulher = (62.1 * altura) - 44.7;

            if (sexo == 'M' || sexo == 'm')
            {
                Console.WriteLine($"O peso de ideal de um homem com {altura} de altura é de {pesoIdealHomem}");
            }
            else if (sexo == 'F' || sexo == 'm')
            {
                Console.WriteLine($"O peso de ideal de uma mulher com {altura} de altura é de {pesoIdealMulher}");
            }
            else
            {
                Console.WriteLine("Sexo inválido. ");
            }
            Console.ReadLine();
        }
    }
}