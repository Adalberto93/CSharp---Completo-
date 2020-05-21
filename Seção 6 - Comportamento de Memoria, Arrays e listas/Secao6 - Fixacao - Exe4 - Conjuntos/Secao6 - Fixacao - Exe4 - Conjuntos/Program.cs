using System;
using System.Collections.Generic;

namespace Secao6___Fixacao___Exe4___Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de identificar a quantidade de alunos diferente de um professor que possui três cursos diferentes.");

            int qtdAlunos;
            int codAluno;

            Console.WriteLine();
            Console.WriteLine("O Curso A possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            HashSet<int> A = new HashSet<int>();

            for (int i = 0; i < qtdAlunos; i++)
            {
                codAluno = int.Parse(Console.ReadLine());
                A.Add(codAluno);
            }

            Console.WriteLine();
            Console.WriteLine("O Curso B possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            HashSet<int> B = new HashSet<int>();

            for (int i = 0; i < qtdAlunos; i++)
            {
                codAluno = int.Parse(Console.ReadLine());
                B.Add(codAluno);
            }

            Console.WriteLine();
            Console.WriteLine("O Curso C possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            HashSet<int> C = new HashSet<int>();

            for (int i = 0; i < qtdAlunos; i++)
            {
                codAluno = int.Parse(Console.ReadLine());
                C.Add(codAluno);
            }

            Console.WriteLine();
            A.UnionWith(B) ;
            A.UnionWith(C);

            Console.WriteLine("Total de Alunos é: " + A.Count);
        }
    }
}
