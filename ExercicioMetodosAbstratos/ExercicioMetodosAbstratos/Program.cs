using ExercicioMetodosAbstratos.Entities;
using System.Globalization;

namespace ExercicioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> contributors = new List<Contributor>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char contributorType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string contributorName = Console.ReadLine();
                Console.Write("Anual Income: ");
                double contributorIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(contributorType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contributors.Add(new IndividualContributor(contributorName, contributorIncome, healthExpenditures));
                } else if (contributorType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    contributors.Add(new CompanyContributor(contributorName, contributorIncome, numberOfEmployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (var contributor in contributors)
            {
                Console.WriteLine(contributor.Name + ": $ " + contributor.CalculateTax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            double totalTax = 0;
            foreach (var contributor in contributors)
            {
                totalTax += contributor.CalculateTax();
            }

            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
