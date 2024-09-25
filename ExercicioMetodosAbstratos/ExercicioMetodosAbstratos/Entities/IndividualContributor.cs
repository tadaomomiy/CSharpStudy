using System.Globalization;
namespace ExercicioMetodosAbstratos.Entities
{
    internal class IndividualContributor : Contributor
    {
        public double HealthExpenditures { get; set; }

        public IndividualContributor(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculateTax()
        {
            double healthExpenditureDiscount = HealthExpenditures * 0.5;

            if (AnualIncome < 20000.0)
            {
                return (AnualIncome * 0.15) - healthExpenditureDiscount;
            } else
            {
                return (AnualIncome * 0.25) - healthExpenditureDiscount;
            }
        }
    }
}
