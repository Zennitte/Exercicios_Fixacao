using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idadeVotar = DateTime.Now.Year - anoNascimento;

            if (idadeVotar >= 16)
            {
                Console.WriteLine("Você está elegível pra votar");
            }
            else
            {
                Console.WriteLine("Você não está elegível para votar");
            }


        }

    }
}
