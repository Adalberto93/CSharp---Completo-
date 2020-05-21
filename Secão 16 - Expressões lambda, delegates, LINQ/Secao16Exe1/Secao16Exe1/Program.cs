using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq; 
using Secao16Exe1.Entities;

namespace Secao16Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este programa tem como objetivo ter ler dados de um funcionario e fornecer algumas informações conforme solicitado.");

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(@path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            // MOSTRAR EM ORDER ALFABETICA O EMAIL DOS FUNCIONARIOS CUJO O SALARIO EH MAIOR QUE O VALOR INFORMADO
            var func = employees.Where(e => e.Salary > value).OrderBy(e => e.Email);
            foreach (Employee obj in func)
            {
                Console.WriteLine(obj.Email);
            }

            Console.WriteLine();
            // MOSTRAR O SOMA DOS SALARIOS DAS PESSOAS QUE COMECEM COM M
            var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
