﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heranca3.Entities;
using System.Globalization;

namespace heranca3
{
    internal class Program
    {

        static void Main(string[] args)
        {
        List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n =  int.Parse(Console.ReadLine()); 

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch =  char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours =int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                if (ch == 'y')
                {
                    Console.Write("Addictional Charge :");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                    list.Add(new OutsourcedEmployee(Name , hours, valuePerHours, additionalCharge));    
                }
                else
                {
                    list.Add(new Employee(Name , hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS : ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ "+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));    
            }


        }
    }
}
