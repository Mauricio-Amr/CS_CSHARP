using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_abstracao1.Entities;
using Ex_abstracao1.Entities.Enum;
using System.Globalization;

namespace Ex_abstracao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista de objetos tipo Shape
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)?");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (c == 'r')
                {
                    Console.WriteLine("Width : ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height : ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Add na lista de obj Shape , o  Retangulo
                    list.Add(new Rectangle(width, height, color));
                    
                }
                else if (c == 'c')
                {
                    Console.WriteLine("Radius : ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Add na lista de obj Shape , o circulo
                    list.Add(new Circle(radius, color));

                }

              
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS : ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
