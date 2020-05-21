using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int qtdQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura(mesma lina):");
            string[] inf = Console.ReadLine().Split(' ');
            string infLastName = inf[0];
            int infIdade = int.Parse(inf[1]);
            double infAltura = double.Parse(inf[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Os valaores digitados foram: ");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(valorProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(infLastName);
            Console.WriteLine(infIdade);
            Console.WriteLine(infAltura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
