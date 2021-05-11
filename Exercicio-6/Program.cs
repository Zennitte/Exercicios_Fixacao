using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;
            nomes = new string[3];

            Console.WriteLine($"Digite {nomes.Length} nomes");

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° nome");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Qual nome você quer buscar");
            string nomeVerificar = Console.ReadLine();
            bool encontrado = false;

            foreach (var item in nomes)
            {
                if (nomeVerificar == item)
                {
                    encontrado = true;
                }
                // else
                // {
                //     Console.WriteLine("Não Achei");
                // }
                // if(item != nomeVerificar)
                // {
                //     Console.WriteLine("Não achei");
                // }
            }
            if (encontrado)
            {
                Console.WriteLine("Achei!!");
            }
            else
            {
                Console.WriteLine("Não Achei!!");
            }
        }
    }
}
