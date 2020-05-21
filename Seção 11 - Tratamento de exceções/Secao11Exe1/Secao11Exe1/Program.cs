using System;
using System.Globalization;
using Secao11Exe1.Entities;
using Secao11Exe1.Entities.Exceptions;

namespace Secao11Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, esse programa tem o objetivo de realizar o controle de saque de uma determinada conta.");
            Console.WriteLine();

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine("New balance: $ " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }

            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }


        }
    }
}
