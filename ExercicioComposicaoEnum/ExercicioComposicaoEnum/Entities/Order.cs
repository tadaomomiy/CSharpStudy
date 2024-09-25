using ExercicioComposicaoEnum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComposicaoEnum.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(Client client, OrderStatus status)
        {
            Moment = DateTime.Now;
            Client = client;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            
            foreach (OrderItem item in OrderItems)
            {
                sum += item.Quantity * item.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($" ({Client.BirthDate.ToString("dd/MM/yyyy")}) - ");
            sb.AppendLine(Client.Name);
            sb.AppendLine("Order Items");
            foreach (OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name + ", $");
                sb.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: ");
                sb.Append(item.Quantity.ToString() + ", Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
