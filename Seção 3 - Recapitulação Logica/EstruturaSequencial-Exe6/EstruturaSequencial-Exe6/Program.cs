using System;
using System.Globalization;

namespace EstruturaSequencial_Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular a área de varias formas geometricas.");
            Console.WriteLine("Informe três valores(A, B e C) com ponto flutuante de dupla precisão:    ");
            string[] pontos = Console.ReadLine().Split(' ');
            float a = float.Parse(pontos[0], CultureInfo.InvariantCulture);
            float b = float.Parse(pontos[1], CultureInfo.InvariantCulture);
            float c = float.Parse(pontos[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c / 2);
            Console.WriteLine("A área do TRIANGULO RETÂNGULO é: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

            double circulo = (3.14159) * (c * c); 
            Console.WriteLine("A área do CIRCULO de base C é: " +  circulo.ToString("F3", CultureInfo.InvariantCulture));

            double trapezio = 0.5 * c * (a + b);
            Console.WriteLine("A área do TRAPÉZIO de bases A e B e altura C é: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            double quadrado = b * b;
            Console.WriteLine("A área do QUADRADO de lado B é: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

            double retangulo = a * b;
            Console.WriteLine("A área do RETÂNGULO RETANGULO de lados A e B é: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
