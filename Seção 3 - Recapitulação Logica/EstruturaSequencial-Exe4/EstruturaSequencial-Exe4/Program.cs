using System;
using System.Globalization;

namespace EstruturaSequencial_Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular o valor do salario de um funcionario.");
            Console.WriteLine("Por favor, digite o codigo do funcionario: ");
            int codFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de horas/mês trabalhada: ");
            double qtdHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite o seu valor hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = qtdHora * valorHora;

            Console.WriteLine("O salario para do funcionario " + codFunc + " é : U$ " +salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
