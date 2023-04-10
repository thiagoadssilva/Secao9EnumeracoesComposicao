using ExercicioTreino01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreino01.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void removeItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
        public double total() {
            double t = 0;
            
            foreach (OrderItem item in Items)
            {
                t += item.subTotal();
            }
            return t;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Resultado do Pedido!");
            sb.AppendLine("Data do Pedido: " +Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Cliente: " + Client.Name + " " + Client.BirthDate.ToString("dd/MM/yyyy" + " - " + Client.Email));
            sb.AppendLine("Ordem dos Items");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + ", " + item.Product.Price.ToString("F2") + ", Quantidade:" + item.Quantity + ", SubTotal: " + item.subTotal().ToString("F2"));
            }
            sb.AppendLine("Total do Pedido: " + total().ToString("F2"));
            
            return sb.ToString();
        }
    }
}
