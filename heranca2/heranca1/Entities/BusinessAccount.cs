using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca2.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoadLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoadLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoadLimit) 
            { 
            Balance += amount;
            }
        }
    }
}
