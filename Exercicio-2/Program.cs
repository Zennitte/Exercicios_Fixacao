using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível você ira querer abastecer: A para álcool ou G para gasolina");
            string tipoCombustivel = Console.ReadLine().ToUpper();

            Console.WriteLine("Quantos litros você quer abastecer?");
            double quantidadeLitros = double.Parse(Console.ReadLine());

            double valorA = quantidadeLitros * 4.90;
            double valorG = quantidadeLitros * 5.30;


            switch (tipoCombustivel)
            {
                case "A":

                    if (quantidadeLitros <= 20)
                    {
                        double desconto = valorA * 0.03;
                        double valorDesconto = valorA - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    else
                    {
                        double desconto = valorA * 0.05;
                        double valorDesconto = valorA - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    break;
                case "G":
                    if (quantidadeLitros <= 20)
                    {
                        double desconto = valorG * 0.04;
                        double valorDesconto = valorG - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    else
                    {
                        double desconto = valorG * 0.06;
                        double valorDesconto = valorG - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        }
    }
}
