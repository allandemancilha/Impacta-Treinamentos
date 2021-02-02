using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            //! String

            // Declarando a Variável name Através da Palavra Reservada string
            string name = "Allan";
            // Declarando a Variável surname Através da Classe System.String
            System.String surname = "Mancilha";

            //! Numéricos Integrais
            short a = 32767;
            System.Int16 b = -32767;

            int c = 2147483647;
            System.Int32 d = -2147483647;

            long e = 9223372036854775807;
            System.Int64 f = -9223372036854775807;

            byte g = 255;

            //! Numéricos de Ponto Flutuante
            double h = 32.45;

            // Conversão Para Decimal Utilizando a Classe Convert
            decimal i = Convert.ToDecimal(1000.99);
            // Conversão Para Decimal Utilizando Convenção
            decimal j = 1000.99m;

            //! Data/Hora

            // Utilizando a Propriedade .Now Para Obter a Data/Hora Atual
            DateTime date = DateTime.Now;
            DateTime specificDate = new DateTime(2050, 12, 21);

            // Utilizando String de Formatação Para Exibir a Data/Hora em Diversos Formatos
            Console.WriteLine("{0:d}", specificDate); // Saída: 21/12/2050
            Console.WriteLine("{0:D}", specificDate); // Saída: quarta-feira, 21 de dezembro de 2050
            Console.WriteLine("{0:ddd}", specificDate); // Saída: qua
            Console.WriteLine("{0:dddd}", specificDate); // Saída: quarta-feira

            // Utilizando String de Formatação Para Exibir o Valor de Acordo Com a Moeda Local
            Console.WriteLine("{0:c}", j); // Saída: R$ 1.000,99

            Console.ReadLine();
        }
    }
}


