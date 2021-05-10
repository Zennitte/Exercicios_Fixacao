using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            Console.WriteLine("Digite 10 números");
            numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine($"O menor número é: {numeros[0]}");
            Console.WriteLine($"O menor número é: {numeros[9]}");



        }
    }
}
