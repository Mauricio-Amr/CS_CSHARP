﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca2.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate {get; set;}

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)       
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;

        }

        // sobre escrever o  metodo  account , com virtual

        public override void Withdraw(double amount)
        {
           base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
