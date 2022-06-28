using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_produto
{
    internal class Program
    {


        static void Main(string[] args)

        {
            Produto p = new Produto();
            Console.WriteLine("Entre com o dados do produto : ");
            Console.Write("Nome : ");
            p.Nome = Console.ReadLine();
            Console.Write ("Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque : ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o  numero de produtos a ser adicionados :");
            int qte =  int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine ("Dados atualizados : " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o  numero de produtos a ser removido :");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dados atualizados : " + p);

        }
    }
}
