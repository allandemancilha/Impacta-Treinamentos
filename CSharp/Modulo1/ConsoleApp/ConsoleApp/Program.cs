using System;

// Observação: Palavras Reservadas da Linguagem C# São Escritas Com Letras Minúsculas.
namespace ConsoleApp
{
    class Program
    {
        /* 
         * Main: Método da Classe Program Que o Sistema Operacional Procura Para Executar o Aplicativo, ou Seja, 
           Método Responsável Pela Incialização.

         * void: Tipo de Retorno Que o Método Apresenta. void Significa Que o Método Não Retorna Nada. 
         
         * static: Significa Que o Método é Fixo na Memória, ou Seja, Não é Alocado na Memória Dinamicamente.
         
         * (string[] args): Parâmetro do Método Main. É Uma Matriz String Que Representa os Argumentos da 
           Linha de Comando.
        */
        static void Main(string[] args)
        {
            // Utilizando a Classe Console e Método WriteLine Para Exibir Uma Mensagem.
            Console.WriteLine("Hello World!");

            // Utilizando a Classe Console e Método ReadLine Para Ler o Valor Digitado.
            Console.ReadLine();
        }
    }
}
