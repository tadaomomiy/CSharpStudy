using ExercicioInterface.Entities;
using ExercicioInterface.Services;
using System.Globalization;

namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            ContractService contractService = new ContractService(new PaypalTaxService());

            contractService.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
