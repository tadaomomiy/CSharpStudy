using ExHeranca.Entities;

namespace ExHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Relação "é um"
            // Generalização/ especialização
            // Superclasse (classe base) / subclasse (classe derivada)
            // Herança / extensão
            // Herança é uma associação entre classes (e não entre objetos)

            BussinessAccount account = new BussinessAccount(8010, "Bob Brown", 100.00, 500.00);
            Console.WriteLine(account.Balance);
        }
    }
}
