using System;
using System.Globalization;

namespace Classe_Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo receber dados de dois funcionarios e exibir o salario medio.");

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Por favor, digite os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Muito bem, agora digite os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("O salário médio é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
