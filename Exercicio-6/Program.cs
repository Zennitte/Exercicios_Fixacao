using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;

            Console.WriteLine("Digite 10 nomes");
            nomes = new string[10];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° nome");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Qual nome você quer buscar");
            string nomeVerificar = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (item == nomeVerificar)
                {
                    Console.WriteLine("Achei");
                }
                // if(item != nomeVerificar)
                // {
                //     Console.WriteLine("Não achei");
                // }
            }
        }
    }
}
