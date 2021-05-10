using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do produto");
            double valorUnitario = double.Parse(Console.ReadLine());

            double total = quantidade * valorUnitario;
            Console.WriteLine($"O total é de {total}");

            if (quantidade <= 5)
            {
                Console.WriteLine("Você tem um desconto de 2%");
                double desconto = total * 0.02;
                double totalDesconto = total - desconto;
                Console.WriteLine($"Seu total a pagar é: {totalDesconto}");
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                Console.WriteLine("Você tem um desconto de 3%");
                double desconto = total * 0.03;
                double totalDesconto = total - desconto;
                Console.WriteLine($"Seu total a pagar é: {totalDesconto}");
            }
            else if (quantidade > 10)
            {
                Console.WriteLine("Você tem um desconto de 5%");
                double desconto = total * 0.05;
                double totalDesconto = total - desconto;
                Console.WriteLine($"Seu total a pagar é: {totalDesconto}");
            }
        }
    }
}
