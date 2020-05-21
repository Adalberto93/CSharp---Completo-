using System;
using System.Globalization;

namespace Secao5___Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.00;
            ContaBancaria dadosconta;

            Console.WriteLine("Olá, este programa tem o objetivo de simular um sistema bancario de depositos e saque.");
            Console.Write("Por favor, digite o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char indDeposito = char.Parse(Console.ReadLine());

            if (indDeposito == 's' || indDeposito == 'S')
            {
                Console.Write("Entre com o valor do deposito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dadosconta = new ContaBancaria(nome, conta, valor);
            }
            else
            {
                dadosconta = new ContaBancaria(nome, conta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(dadosconta);

            Console.WriteLine();
            Console.Write("Entre com o valor do Depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosconta.Deposito(valor);

            Console.WriteLine("Dados da Atualizados: ");
            Console.WriteLine(dadosconta);

            Console.WriteLine();
            Console.Write("Entre com o valor do Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosconta.Saque(valor);

            Console.WriteLine("Dados da Atualizados: ");
            Console.WriteLine(dadosconta);

        }
    }
}
