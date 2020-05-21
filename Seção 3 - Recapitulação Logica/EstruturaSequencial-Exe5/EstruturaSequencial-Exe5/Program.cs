using System;
using System.Globalization;

namespace EstruturaSequencial_Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de calcular o valor total a ser pago para dois produtos informados.");
            Console.WriteLine("Por favor, digite o código da primeira peça, quantidade e valor unitario: ");
            string[] infPeca1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(infPeca1[0]);
            int qtdPeca1 = int.Parse(infPeca1[1]);
            double valorPeca1 = double.Parse(infPeca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Agora digite o código da segunda peça, sua quantidade e valor unitário: ");
            string[] infPeca2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(infPeca2[0]);
            int qtdPeca2 = int.Parse(infPeca2[1]);
            double valorPeca2 = double.Parse(infPeca2[2], CultureInfo.InvariantCulture);

            double valorTot = (qtdPeca1 * valorPeca1) + (qtdPeca2 * valorPeca2);
            Console.WriteLine("O valor total a ser pago é: R$ " + valorTot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
