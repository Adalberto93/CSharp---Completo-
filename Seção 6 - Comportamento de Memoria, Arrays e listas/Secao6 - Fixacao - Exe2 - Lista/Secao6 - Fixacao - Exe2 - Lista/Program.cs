using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Secao6___Fixacao___Exe2___Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem o objetivo armazenar uma lista de funcionario e calcular o reajuste salarial.");

            Console.Write("Por favor, informe quantos quartos funcionarios deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Funcionario #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                bool encontrou = false;
                while (encontrou == false)
                {
                    Funcionario achou = list.Find(x => x.Id == id);
                    if (achou != null)
                    {
                        Console.WriteLine("A ID ja cadastrado, por favor, informe outro ID");
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        encontrou = true;
                    }
                }
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Por favor, informe o ID do funcionario que deseja aumentar o salario: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == idAumento);
            if (emp != null)
            {
                Console.Write("Qual o percentual que deseja aumentar? ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(percent);
            }
            else
            {
                Console.WriteLine("Este ID de funcionario não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios atualizada: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
