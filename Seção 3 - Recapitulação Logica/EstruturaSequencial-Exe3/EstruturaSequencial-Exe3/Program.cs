using System;

namespace EstruturaSequencial_Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular a diferença do produto de A e B pelo produto C e D.");
            Console.WriteLine("Por favor, digite os valores inteiros correspondete a A e B: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Certo, agora digite os valores inteiros correspondente a C e D: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine("A diferença do produto para os valores digitados é: ");
            Console.WriteLine(diferenca);

        }
    }
}
