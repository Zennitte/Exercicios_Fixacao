using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[15];

            Console.WriteLine($"Digite {numeros.Length} números");

            for (var i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Digite o {i + 1}° numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
