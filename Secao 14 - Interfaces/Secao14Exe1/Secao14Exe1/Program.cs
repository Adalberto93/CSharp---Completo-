using System;
using Secao14Exe1.Entities;
using System.Globalization;


namespace Secao14Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, esse programa tem o objetivo de automatizar o processamento de contratos e calculo de parcelas!");

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numberContract = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int quantityInstallment = int.Parse(Console.ReadLine());

            Contract conctract = new Contract(numberContract, date, value, quantityInstallment);

            conctract.CalculateInstalment();

            Console.WriteLine();
            Console.WriteLine(conctract);
            Console.ReadLine();

        }
    }
}
