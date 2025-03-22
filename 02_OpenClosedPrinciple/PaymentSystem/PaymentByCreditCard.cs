namespace _02_OpenClosedPrinciple.PaymentSystem
{
    internal class PaymentByCreditCard
    {
        public string PaymentviaCreditCard(decimal amount)
        {
            return $" {amount} amount was paid by credit card.";
        }
    }
}
