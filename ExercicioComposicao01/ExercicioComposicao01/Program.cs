using ExercicioComposicao01.Entities.Enums;
using System.Globalization;
using System;
using ExercicioComposicao01.Entities;

namespace ExercicioComposicao01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu departamento: ");
            string depatName = Console.ReadLine();
            Console.WriteLine("Entre com a data de trabalho:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Nevel entre (Junoir/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Seu salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            Departament dept = new Departament(depatName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contrato você tem: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Entre com o {i}º contrato");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Qual o valor hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContratc(contract);
            }

            Console.WriteLine();
            Console.Write("Informe o ano e o mês para fazer o calculo: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine("Total dos contratos mais o salario: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}