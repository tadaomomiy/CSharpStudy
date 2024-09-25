using System.Globalization;

namespace ExSpecialTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TernaryCondicionalTest();
        }

        static void SwitchTest()
        {

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
            }
        }

        static void TernaryCondicionalTest()
        {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
