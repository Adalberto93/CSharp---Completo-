using System;
using System.Globalization;

namespace EstruturaCondicional_Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular o valor do imposto conforme salario informado.");
            // TABELA DE IMPOSTO
            //  0,00        a 2000,00 - ISENTO
            //  2000,01     a 3000,00 - 8  %
            //  3000,01     a 4500,00 - 18 %
            //  acima 4500,00         - 28 %
            Console.WriteLine("Por favor, digite o valor do salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imp28 = 0.00;
            double imp18 = 0.00;
            double imp8 = 0.00;

            if (salario > 4500.00)
            {
                imp28 = 0.28 * (salario - 4500);
                imp18 = 0.18 * 1499.99;
                imp8 = 0.08 * 999.99;
            }
            else if (salario > 3000.00 && salario < 4500.01)
                 {
                    imp18 = 0.18 * (salario - 3000.01);
                    imp8 = 0.08 * 999.99;
                 }
                 else if(salario > 2000.00 && salario < 3000.01)
                      {
                        imp8 = 0.08 * (salario - 2000.01);
                      }

            double imptotal = imp28 + imp18 + imp8;

            if (imptotal > 0.00)
            {
                Console.WriteLine("Imposto total a ser pago é: R$ " + imptotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else 
            {
                Console.WriteLine("Salario ISENTO de imposto!");
            }
        }
    }
}
