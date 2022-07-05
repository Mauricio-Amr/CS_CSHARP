using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using composition3.entities.Enum;
using System.Globalization;


namespace composition3.entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } 
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> items { get; set; } = new List<OrderItem>();


        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItens(OrderItem item)
        {
            items.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();

            }
            return sum;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment:  " + Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client : " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price : $" + Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }
    }
}
