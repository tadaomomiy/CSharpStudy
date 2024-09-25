using System.Globalization;
using System.Collections.Generic;

namespace ExercicioList {
    internal class Program {
        static void Main(string[] args) {
            List<Employee> company = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++) {
                Console.WriteLine("Employee #{0}", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                company.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee searchedEmployee = company.Find(x => x.Id == idIncrease);

            if (searchedEmployee != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                searchedEmployee.IncreaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (object employee in company) {
                Console.WriteLine(employee);
            }
        }
    }
}
