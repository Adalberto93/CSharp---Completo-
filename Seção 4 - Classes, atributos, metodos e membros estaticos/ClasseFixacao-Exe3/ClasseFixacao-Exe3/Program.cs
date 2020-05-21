using System;
using System.Globalization;

namespace ClasseFixacao_Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de identificar se um aluno foi aprovado ou reprovado.");

            Aluno infAluno;
            infAluno = new Aluno();

            Console.WriteLine("Por favor, digite as informações do aluno: ");
            Console.Write("Nome: ");
            infAluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            infAluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            infAluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            infAluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notafinal = infAluno.CalcularNota();
            Console.WriteLine("Nota Final = " + notafinal.ToString("F2", CultureInfo.InvariantCulture));

            infAluno.AvaliarNota(notafinal);

        }
    }
}
