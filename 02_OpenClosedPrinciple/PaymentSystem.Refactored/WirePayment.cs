namespace _02_OpenClosedPrinciple.PaymentSystem.Refactored
{
    internal class WirePayment : IPaymentService
    {
        public string MakePayment(decimal amount)
        {
            return $" {amount} amount was paid by wire.";
        }
    }
}
