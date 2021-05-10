using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            for (int e = 1; e <= 10; e++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{e}x{i} = {e * i}");
                }
                Console.WriteLine();
            }
        }
    }
}
