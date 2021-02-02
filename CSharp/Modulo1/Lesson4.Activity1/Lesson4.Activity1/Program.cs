using System;

namespace Lesson4.Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;

            Console.Write("Digite o 1° Número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° Número: ");
            y = Convert.ToInt32(Console.ReadLine());

            result = x + y;
            Console.Write("Resultado da Soma: {0}", result);

            Console.ReadLine();
        }
    }
}

