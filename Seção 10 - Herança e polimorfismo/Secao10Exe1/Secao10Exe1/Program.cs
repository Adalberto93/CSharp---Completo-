using Secao10Exe1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Secao10Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Esse programa tem o objetivo de ler N produtos e mostrar a etiqueta conforme sua origem.");

            Console.WriteLine();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

           List<Product> listprod = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tipoProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipoProduct)
                 {
                    case 'c':
                    case 'C':
                        listprod.Add(new Product(name, price));
                        break;
                    case 'u':
                    case 'U':
                        Console.Write("Manufacture date (DD/MM/YYYY): "  );
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        listprod.Add(new UsedProduct(name, price,manufactureDate));
                        break;
                    case 'i':
                    case 'I':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        listprod.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case '\0':
                        Console.WriteLine("Invalid product");
                        break;   
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product prod in listprod)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
