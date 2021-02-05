using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um Número Entre 1-10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 10)
            {
                Console.WriteLine("Número Fora da Faixa.");
            }
            else
            {
                Console.WriteLine("Obrigado!");
            }

            Console.WriteLine("Aperte Alguma Tecla Para Continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Dia, Tarde ou Noite?");
            Console.WriteLine();

            int hour = DateTime.Now.Hour;

            if (hour > 17)
            {
                Console.WriteLine("Boa Noite!");
            } 
            else if (hour > 11)
            {
                Console.WriteLine("Boa Tarde!");
            } 
            else
            {
                Console.WriteLine("Bom Dia!");
            }

            Console.WriteLine("Aperte Alguma Tecla Para Encerrar...");
            Console.ReadLine();
        }
    }
}
