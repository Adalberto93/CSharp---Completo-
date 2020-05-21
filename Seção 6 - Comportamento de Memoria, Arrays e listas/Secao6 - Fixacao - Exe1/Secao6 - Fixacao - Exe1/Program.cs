using System;
using System.Globalization;

namespace Secao6___Fixacao___Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de realizar o controle de uma pensão.");

            Console.WriteLine("Por favor, informe quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Cliente[] vect = new Cliente[11];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();  
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Qual o nome do hospede? ");
                string name = Console.ReadLine();

                Console.Write("Qual o e-mail do hospede? ");
                string email = Console.ReadLine();

                Console.Write("Qual o quarto que deseja alugar? ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Cliente(name, email);
            }

            if (n > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Quartos ocupados: ");

                for (int i = 0; i <= 10; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(i + ": " + vect[i]);
                    }
                }
            }
        }
    }
}
