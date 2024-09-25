namespace ExercicioMetodosAbstratos.Entities
{
    internal abstract class Contributor
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public Contributor() { }

        public Contributor(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double CalculateTax();
    }
}
