using System;
using System.Globalization;

namespace ClasseFixacao_Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular o aumento do salario de um funcionario.");

            Funcionario func;
            func = new Funcionario();

            Console.WriteLine("Por favor, informe os dados do funcionario: ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(perc);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + func);




        }
    }
}
