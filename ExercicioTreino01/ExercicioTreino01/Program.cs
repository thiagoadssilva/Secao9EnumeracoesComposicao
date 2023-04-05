using ExercicioTreino01.Entities;
using ExercicioTreino01.Entities.Enums;
using System;
using System.Globalization;
namespace ExercicioTreino01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY) ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Quantos item no seu pedido");
            int qdt = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= qdt; i++)
            {
                Console.WriteLine($"Entre #{i} dados do item");
                Console.Write("Nome do Produto: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Valor do Produto: ");
                double valueProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtdProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, valueProduct);
                OrderItem orderItem = new OrderItem(qtdProduct, valueProduct, product);
                order.Items.Add(orderItem);
            }
            
            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}