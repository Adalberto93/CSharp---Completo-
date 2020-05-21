using System;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Secao13Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá este programa tem o objetivo de ler um arquivo e gera um novo arquivo sumarizando os valores do arquivo de entrada:");

            // CAMINHO ARQUIVO DE ENTRADA
            string sourceFilePath = @"C:\Users\adalb\OneDrive\Área de Trabalho\ws-vs2019\Projetos\Secao 13\entrada.csv";

            try
            {
                //  OBTENDO TODAS AS LINHAS DO ARQUIVOS 
                string[] lines = File.ReadAllLines(sourceFilePath);

                //OBTENDO CAMINHO DE SAIDA (PASTA E ARQUIVO)
                //  string targetFolderPath = Path.GetDirectoryName(sourceFilePath) + @"\out";
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                // CRIANDO PASTA DE SAIDA
                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] entrada = line.Split(',');
                        string name = entrada[0];
                        double price = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(entrada[2]);

                        // CALCULANDO O VALOR SUMARIZADO
                        double sum = price * quantity;

                        // MONTANDO O ARQUIVO DE SAIDA
                        string saida = name + ',' + sum.ToString("F2", CultureInfo.InvariantCulture);
  
                        sw.WriteLine(saida);
                    }
                }
                Console.WriteLine("Programa finalizado com sucesso!");
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
