using System;
using System.Globalization;

namespace EstruturaSequencial_Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Olá, este programa tem o objetivo de calcular o valor da área de um circulo apartir do seu raio.");
            Console.WriteLine("Por Favor, digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (raio * raio);

            Console.WriteLine("A área do circulo para o raio informado é: ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            
        }
    }
}
