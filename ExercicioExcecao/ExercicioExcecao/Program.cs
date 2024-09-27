using ExercicioExcecao.Entities;
using ExercicioExcecao.Entities.Exceptions;
using System.Globalization;

namespace ExercicioExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdrawAmount);
                Console.Write("New balance: " + account.Balance);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message); 
            }
        }
    }
}
