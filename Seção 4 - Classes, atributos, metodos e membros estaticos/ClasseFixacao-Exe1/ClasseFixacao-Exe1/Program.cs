using System;
using System.Globalization;

namespace ClasseFixacao_Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcula área, perimetro e diagonal de um triangulo.");

            Triangulo dados;
            dados = new Triangulo();

            Console.WriteLine("Por favor, informe a largura e altura do triangulo: ");
            dados.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + dados.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + dados.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + dados.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
