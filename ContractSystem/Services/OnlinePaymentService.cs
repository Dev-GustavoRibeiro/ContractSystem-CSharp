namespace ContractSystem.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFree(double amount);
        public double Interest(double Amount, int months);
    }
}
