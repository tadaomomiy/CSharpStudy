using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    internal class ContractService
    {
        private ITaxService _TaxSevice;

        public ContractService(ITaxService taxSevice)
        {
            _TaxSevice = taxSevice;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double quota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime quotaDate = contract.Date.AddMonths(i);
                double updatedQuota = quota + _TaxSevice.Interest(quota, i);
                double fullQuota = updatedQuota + _TaxSevice.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(quotaDate, fullQuota));
            }
        }
    }
}
