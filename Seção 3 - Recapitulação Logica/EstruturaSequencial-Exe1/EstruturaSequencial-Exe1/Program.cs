using System;
using System.Reflection;

namespace EstruturaSequencial_Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de somar dois números inteiros.");
            Console.WriteLine("Por favor, digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Muito bem, agora digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine("A soma dos valores digitados é: ");
            Console.WriteLine(soma);
        }
    }
}
