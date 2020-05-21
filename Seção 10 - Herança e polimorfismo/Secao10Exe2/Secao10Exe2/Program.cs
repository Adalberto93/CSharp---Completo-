using System;
using System.Collections.Generic;
using System.Globalization;
using Secao10Exe2.Entities;

namespace Secao10Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O objetivo desse programa é calcular o imposto conforme o tipo de pessoa informado.");

            List<Person> listPerson = new List<Person>();

            Console.WriteLine();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c)? ");
                char tpPerson = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tpPerson == 'i' || tpPerson == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listPerson.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int qtdEmployees = int.Parse(Console.ReadLine());
                    listPerson.Add(new Company(name, anualIncome, qtdEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTax = 0.0;
            foreach (Person msg in listPerson)
            {
                double tax = msg.Tax();
                Console.WriteLine(msg.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTax += tax;
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
