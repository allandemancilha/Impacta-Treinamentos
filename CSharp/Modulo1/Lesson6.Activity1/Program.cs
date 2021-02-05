using System;

namespace Lesson6.Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Valor da Compra: R$ ");
            decimal purchasePrice = Convert.ToDecimal(Console.ReadLine());
            decimal priceMinimumToParcels = 1000.01m;

            Console.WriteLine("Valor à Vista: {0:c}", purchasePrice);

            if (purchasePrice >= priceMinimumToParcels) 
            {
                int installmentsNumber = 3;
                decimal installmentsPrice = Convert.ToDecimal(purchasePrice / installmentsNumber);

                Console.WriteLine("{0}x de {1:c}", installmentsNumber, installmentsPrice);
            }

            Console.WriteLine("Tecle ENTER Para Finalizar");
            Console.ReadLine();

        }
    }
}
