using System;
using System.Security.Cryptography;

namespace Classe_Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo receber dados de duas pessoas e exibir o nome da mais velha.");

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Por favor, digite os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Muito bem, agora digite os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
            }

        }
    }
}
