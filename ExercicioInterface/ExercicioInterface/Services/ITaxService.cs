namespace ExercicioInterface.Services
{
    internal interface ITaxService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
