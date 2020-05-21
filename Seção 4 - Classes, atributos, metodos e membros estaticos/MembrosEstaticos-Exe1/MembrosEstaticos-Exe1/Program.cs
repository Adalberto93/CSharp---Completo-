using System;
using System.Globalization;

namespace MembrosEstaticos_Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de converter dolares em reias.");

            Console.Write("Qual é a cotação do dolar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares vocês vai comprar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorReal = ConversorDeMoeda.DolarParaReal(cotacaoDolar, valorDolar);
            Console.WriteLine("Valor a ser pago é: " + valorReal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
