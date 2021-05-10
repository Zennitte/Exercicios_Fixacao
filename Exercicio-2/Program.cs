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
            switch (tipoCombustivel)
            {
                case "A":

                    if (quantidadeLitros <= 20)
                    {
                        double valor = quantidadeLitros * 4.90;
                        double desconto = valor * 0.03;
                        double valorDesconto = valor - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    else
                    {
                        double valor = quantidadeLitros * 4.90;
                        double desconto = valor * 0.05;
                        double valorDesconto = valor - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    break;
                case "G":
                    if (quantidadeLitros <= 20)
                    {
                        double valor = quantidadeLitros * 5.30;
                        double desconto = valor * 0.04;
                        double valorDesconto = valor - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    else
                    {
                        double valor = quantidadeLitros * 5.30;
                        double desconto = valor * 0.06;
                        double valorDesconto = valor - desconto;

                        Console.WriteLine($"O valor do seu abastecimento é igual a: {valorDesconto}");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
