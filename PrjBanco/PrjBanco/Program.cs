using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banco banco = new Banco();

            Console.WriteLine("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nomeTitula = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            string opcao = Console.ReadLine();
            if (opcao == "n")
            {
                ;
                banco.CadastroSemDeposito(numConta, nomeTitula);

            }
            else if (opcao == "s")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                banco.Cadastro(numConta, nomeTitula, deposito);
            }


            Console.WriteLine("Dados da conta ");
            Console.Write(banco);



            Console.WriteLine("\ndigite 'd' para deposito, e 's' para sacar ");
            opcao = Console.ReadLine();
            while (opcao != "e")


                if (opcao == "d")
                {
                    Console.WriteLine("Quanto deseja depositar ");
                    double valor = double.Parse(Console.ReadLine());
                    banco.Deposito = valor;

                    Console.WriteLine(banco);
                    Console.WriteLine("digite 'd' para deposito, e 's' para sacar ou  'e' para sair ");
                    opcao = Console.ReadLine();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Qaunto gostaria de sacar: ");
                    double valor = double.Parse(Console.ReadLine());

                    banco.Sacar = valor;
                    Console.WriteLine(banco);
                    Console.WriteLine("\ndigite 'd' para deposito, e 's' para sacar ou  'e' para sair ");
                    opcao = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\ndigite 'd' para deposito, e 's' para sacar ou  'e' para sair ");
                    opcao = Console.ReadLine();
                }


        }
    }
}
