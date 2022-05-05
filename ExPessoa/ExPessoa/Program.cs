using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa ");
            Console.Write("nome : ");
            p1.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Idade : ");
            p1.idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            Console.WriteLine();
            Console.Write("nome : ");
            p2.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Idade : ");
            p2.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }

        }
    }
}
