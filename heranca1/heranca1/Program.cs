using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heranca1.Entities;

namespace heranca1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Holder);
            Console.WriteLine(account.Balance);


            account.Deposit(200.0);
            Console.WriteLine(account.Balance);



        }
    }
}
