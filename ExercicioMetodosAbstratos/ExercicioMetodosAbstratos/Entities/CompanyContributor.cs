namespace ExercicioMetodosAbstratos.Entities
{
    internal class CompanyContributor : Contributor
    {
        public int NumberOfEmployees { get; set; }

        public CompanyContributor(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculateTax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
