using System;
using System.Security.Cryptography;

namespace EstrutuaWhile_Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de identificar a quantidade de clientes para cada combustivel.");

            // 1 - ALCOOL
            // 2 - GASOLINA
            // 3 - DISEL
            // 4 - FIM 

            int qtdAlcool = 0;
            int qtdGasolina = 0;
            int qtdDisel = 0;

            Console.Write("Por favor, digite o código do combustivel: ");
            int combu = int.Parse(Console.ReadLine());

            combu = ValidarValor(combu);

            while (combu != 4)
            {
                if (combu == 1)
                {
                    qtdAlcool = qtdAlcool + 1;
                }
                else if (combu == 2)
                 {
                    qtdGasolina = qtdGasolina + 1;
                 }
                else
                 {
                    qtdDisel = qtdDisel + 1;
                  }

                Console.Write("Digite o próximo código: ");
                combu = int.Parse(Console.ReadLine());

                combu = ValidarValor(combu);
            }

            Console.WriteLine("Muito Obrigado! ");
            Console.WriteLine("Quantidade total de Álcool: " + qtdAlcool);
            Console.WriteLine("Quantidade total de Gasolina: " + qtdGasolina);
            Console.WriteLine("Quantidade total de Disel: " + qtdDisel);
        }

        static int ValidarValor(int valor)
        {
            while (valor < 1 || valor > 4)
            {
                Console.Write("Código Invalido, digite novamente um valor entre 1 e 4: ");
                valor = int.Parse(Console.ReadLine());
            }

            return valor;
        }
    }
}
