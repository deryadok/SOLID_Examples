namespace _02_OpenClosedPrinciple.PaymentSystem.Refactored
{
    internal class PaymentServiceRefactored
    {
        IPaymentService _paymentService;

        public PaymentServiceRefactored(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public string MakePayment(decimal amount)
        {
            return _paymentService.MakePayment(amount);
        }
    }
}
