﻿
namespace ExAbstrata.Entities
{
    internal class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BussinessAccount()
        {
        }

        public BussinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
