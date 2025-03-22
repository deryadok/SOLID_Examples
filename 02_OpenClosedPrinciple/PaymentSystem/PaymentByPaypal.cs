namespace _02_OpenClosedPrinciple.PaymentSystem
{
    internal class PaymentByPaypal
    {
        public string PaymentviaPaypal(decimal amount)
        {
            return $" {amount} amount was paid by Paypal.";
        }
    }
}
