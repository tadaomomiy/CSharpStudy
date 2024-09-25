﻿
using ExSobreposicaoVirtualOverride.Entities;

namespace ExSobreposicaoVirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use Virtual in superclass to be able override in subclass
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
