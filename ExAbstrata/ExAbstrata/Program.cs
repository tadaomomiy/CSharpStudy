using ExAbstrata.Entities;
using System.Globalization;

namespace ExAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BussinessAccount(1002, "Maria", 500.0, 400.0));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BussinessAccount(1004, "Anna", 500.0, 500.0));

            // Because I had a genereric superclass, I can mix all differents class with same base in that generic list type, being possible to pass through and sum all same attributes
            double sum = 0;
            foreach (Account account in accounts)
            {
                sum += account.Balance;
            }
            Console.WriteLine(sum);

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account account in accounts)
            {
                account.Withdraw(10.0);
            }

            foreach(Account account in accounts)
            {
                Console.WriteLine("Updated balance for account "
                    + account.Number
                    + ": "
                    + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
