using ExercicioEnum01.Entities;
using ExercicioEnum01.Entities.Enums;
using System;

namespace ExercicioEnum01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            // Convertendo o status "PendingPayment" em uma string
            string txt = OrderStatus.PendingPayment.ToString();

            // Convertendo a string "Delivered" em um status do tipo OrderStatus
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}