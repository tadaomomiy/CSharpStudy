namespace ExercicioInterface.Services
{
    internal class PaypalTaxService: ITaxService
    {
        private const double MonthlyInterest = 0.01;
        private const double FeePercentage = 0.02;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
