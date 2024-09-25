using ExPolimorfismo.Entities;
using System.Globalization;

namespace ExPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourcedAnswer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string employeeName = Console.ReadLine();
                Console.Write("Hours: ");
                int employeeWorkedHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourcedAnswer != 'n')
                {
                    Console.Write("Additional charge: ");
                    double outsourceAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(employeeName, employeeWorkedHours, employeeValuePerHour, outsourceAdditionalCharge)) ;
                } else
                {
                    employees.Add(new Employee(employeeName, employeeWorkedHours, employeeValuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
