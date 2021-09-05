using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            Console.Write("Digite seu nome: "); // Digita o primeiro nome do usuário
            firstName = Console.ReadLine();
            Console.Write("Digite seu sobrenome: "); // Digita o sobrenome do usuário
            lastName = Console.ReadLine();

            // ------------------

            Console.WriteLine($"Seu nome é {firstName} {lastName}"); // Escreve o nome digitado
            Console.WriteLine($"Nome de catálogo: {lastName.ToUpper()}, {firstName}"); // Escreve o nome catalogado
        }
    }
}
