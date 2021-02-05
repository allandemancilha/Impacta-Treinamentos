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

            Console.WriteLine("Aperte Enter Para Continuar");
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

            Console.WriteLine("Aperte Enter Para Continuar");
            Console.ReadLine();
            Console.Clear();

            string message = string.Empty;

            int aleatoryNumber = new Random().Next(1, 4);

            switch (aleatoryNumber)
            {
                case 1:
                case 3:
                    message = "ímpar";
                    break;
                case 2:
                case 4:
                    message = "Par";
                    break;
                default:
                    message = string.Empty;
                    break;
            }
            Console.WriteLine(message);

            Console.WriteLine("Aperte Enter Para Finalizar");
            Console.ReadLine();
        }
    }
}
