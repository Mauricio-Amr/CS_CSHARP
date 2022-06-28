using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> lista = new List<Employees>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee " + i + " : ");
                Console.Write("Id : ");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name :");
                string Name = Console.ReadLine();

                Console.WriteLine("Salary :");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Employees(Id, Name, Salary));
                Console.WriteLine();

            }

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int seachId = int.Parse(Console.ReadLine());

            Employees emp = lista.Find(x => x.Id == seachId);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentage : ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist !");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees : ");
            foreach (Employees obj in lista)
            {
                Console.WriteLine(obj);

            }
        }
    }
}
