using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Console.Write("Nome : ");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Salrio Bruto : ");
            funcionario1.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("imposto : ");
            funcionario1.imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionario " + funcionario1);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario1.AumentoSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario1);


        }
    }
}
