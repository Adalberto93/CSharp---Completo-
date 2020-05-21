using System;

namespace Secao6___Fixacao3___Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo de montar um matriz M por N.");

            Console.WriteLine("Por favor, digite o número de linhas e colunas da Matriz: ");
            string [] vet = Console.ReadLine().Split(' ');

            // obtendo o numero de linhas e colunas
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            // declarando a matriz
            int[,] mat = new int[m, n];

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite o valor da linha # " + i);
                string [] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            // Obtendo o numero que esta sendo pesquisado
            Console.WriteLine();
            Console.Write("Digite o numero que deseja procurar: ");
            int x = int.Parse(Console.ReadLine());

            bool encontrou = false;
            // fazendo o loop de pesquisa
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i, j])
                    {
                        encontrou = true;
                        Console.WriteLine();
                        Console.WriteLine("A posição do número pesquisado é: " + i + ',' + j);
                        
                        // valores a esqueda 
                        if ((j-1) >= 0)
                        {
                            Console.WriteLine("O valor a sua ESQUERDA é: " + mat[i, j - 1]);
                        }

                        // valores a direita 
                        if ((j + 1) < n)
                        {
                            Console.WriteLine("O valor a sua DIREITA é: " + mat[i, j + 1]);
                        }

                        // valores a acima 
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine("O valor ACIMA é: " + mat[i-1, j]);
                        }

                        // valores a abaixo 
                        if ((i + 1) < m)
                        {
                            Console.WriteLine("O valor ABAIXO é: " + mat[i+1, j]);
                        }
                    }
                }

            }

           if (encontrou == false)
            {
                Console.WriteLine();
                Console.WriteLine("Número pesquisado não encontrado na matriz!");
            }
        }
    }
}
