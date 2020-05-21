using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {

        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;


            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", cujo preco é R$ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preco é R$ " + preco2.ToString("F2"));

            Console.WriteLine();

            Console.Write("Registro: " + idade + " anos de idade, codigo " + codigo + " e genero " + genero);

            Console.WriteLine();

            Console.WriteLine("Medida com oito casas decimais: " + media);
            Console.WriteLine("Arrendodamento(três casas decimais): " + media.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
