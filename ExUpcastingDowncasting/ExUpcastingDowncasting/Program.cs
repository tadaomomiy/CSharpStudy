using ExUpcastingDowncasting.Entities;

namespace ExUpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Downcasting is unsafe

            BussinessAccount acc4 = (BussinessAccount)acc2;
            acc4.Loan(100.00);

            //BussinessAccount acc5 = (BussinessAccount)acc3;
            if(acc3 is BussinessAccount)
            {
                //BussinessAccount acc5 = (BussinessAccount)acc3;
                BussinessAccount acc5 = acc3 as BussinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
