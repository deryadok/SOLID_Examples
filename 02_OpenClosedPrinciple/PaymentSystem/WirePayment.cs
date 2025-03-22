namespace _02_OpenClosedPrinciple.PaymentSystem
{
    internal class WirePayment
    {
        public string PaymentviaWire(decimal amount)
        {
            return $" {amount} amount was paid by wire.";
        }
    }
}
