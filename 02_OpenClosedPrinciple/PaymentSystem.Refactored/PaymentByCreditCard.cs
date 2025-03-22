namespace _02_OpenClosedPrinciple.PaymentSystem.Refactored
{
    internal class PaymentByCreditCard : IPaymentService
    {
        public string MakePayment(decimal amount)
        {
            return $" {amount} amount was paid by credit card.";
        }
    }
}
