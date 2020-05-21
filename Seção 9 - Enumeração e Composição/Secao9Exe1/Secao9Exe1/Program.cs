using System;
using System.Globalization;
using Secao9Exe1.Entites;
using Secao9Exe1.Entites.Enums;

namespace Secao9Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa tem como objetivo realizar o controle de pedidos.");

            Console.WriteLine("Enter cliente data:" );
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nameClient, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment, Processing, Shipped or Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            DateTime currentDate = DateTime.Now;
            Order order = new Order(currentDate, status, client);

            for (int i = 1; i <= n; i++ )
                {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: " );
                string nameProdutc = Console.ReadLine();
                Console.Write("Product price: ");
                double valorProdutc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtdProdutc = int.Parse(Console.ReadLine());

                Product product = new Product(nameProdutc, valorProdutc);
                OrderItem orderItem = new OrderItem(qtdProdutc, valorProdutc, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
