using System;

namespace Lesson5.Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Valor do Produto: R$ ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a Quantidade: ");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            decimal totalPurchasePrice = productPrice * productQuantity;

            Console.WriteLine("Preço Total da Compra: {0:c}", totalPurchasePrice);
            Console.ReadLine();
        }
    }
}

