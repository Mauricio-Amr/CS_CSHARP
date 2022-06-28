using System;
using ExTrabalhador.Entities.Enum;
using ExTrabalhador.Entities;
using System.Globalization;

namespace ExTrabalhador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter depatament's name : ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter work data");
            Console.Write("Name");
            string name = Console.ReadLine();
            Console.Write("Level : (Junior / Midlevel / Senior) : ");
            
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
          
            Console.Write("Base  salary ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker work = new Worker(name, level, baseSalary, dept);

            Console.Write("how many contracts to  this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hour's) ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                work.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0 ,2 ));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name : "+ work.Name);
            Console.WriteLine("Department : " + work.Department.Name);
            Console.WriteLine("Income for "+ monthAndYear + " : " + work.Income(year, month));


        }
    }
}
