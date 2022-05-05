using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome : ");
            p1.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("salario : ");
            p1.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Nome : ");
            p2.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Salario : ");
            p2.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            float media = (p1.salario + p2.salario) / 2;
            Console.WriteLine("Salario medio = " + media);

        }
    }
}
