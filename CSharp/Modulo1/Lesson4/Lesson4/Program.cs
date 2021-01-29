using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Digite Seu Nome: ");
            // Lendo o Valor Digitado Com o Método ReadLine() e Armazenando o Valor na Variável name.
            name = Console.ReadLine();

            Console.WriteLine("Digite Sua Idade: ");
            // Convertendo o Valor Digitado de String Para Inteiro Através Classe Convert e o Método ToInt32().        
            age = Convert.ToInt32(Console.ReadLine());

            int daysLived = age * 365;
            // Utilizando String de Formatação Para Exibir os Valores no Console.
            Console.WriteLine("Olá {0}, Você já Viveu {1} Dias.", name, daysLived);

            Console.ReadLine();
        }
    }
}
