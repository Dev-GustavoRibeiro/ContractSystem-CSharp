namespace ContractSystem.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        
        public double PaymentFree(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double Amount, int months)
        {
            return Amount * MonthlyInterest * months;
        }
    }
}
