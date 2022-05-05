using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Calculadora calc = new Calculadora();
           

            Console.Write("Digite a largura : ");
            calc.largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura : ");
            calc.altura = double.Parse(Console.ReadLine());

          

            Console.WriteLine("Area  = " + calc.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + calc.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("diagonal = " + calc.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
