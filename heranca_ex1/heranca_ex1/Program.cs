using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heranca_ex1.Entities;
using System.Globalization

namespace heranca_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                if (c == 'i')
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price,customsFee));

                }
                else if(c == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));
                }
                else if(c == 'c')
                {
                    list.Add(new Product(name, price)); 
                }


            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAG :");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

       
        }
    }
}
