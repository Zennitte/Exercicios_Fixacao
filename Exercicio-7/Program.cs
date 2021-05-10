using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            Console.WriteLine("Digite 15 números");
            numeros = new int[15];

            for (var i = 14; i <= 14; i--)
            {
                Console.WriteLine($"Digite o {i + 1}° numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
