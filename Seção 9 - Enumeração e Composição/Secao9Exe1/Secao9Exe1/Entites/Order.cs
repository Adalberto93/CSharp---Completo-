using Secao9Exe1.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao9Exe1.Entites
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem valor in Items)
            {
                sum += valor.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name +  Client.BirthDate.ToString(" (dd/MM/yyyy)") + " - " + Client.Email);
          //  sb.Append(Client.BirthDate.ToString(" (dd/MM/yyyy)") + " - " + Client.Email);
          //  sb.Append(" - ");
          //  sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");

            foreach (OrderItem obj in Items)
            {
                sb.AppendLine(obj.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
