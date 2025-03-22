namespace _02_OpenClosedPrinciple.PaymentSystem
{
    internal class PaymentService
    {
        PaymentByCreditCard _paymentByCreditCard;
        PaymentByPaypal _paymentByPaypal;
        WirePayment _wirePayment;

        public PaymentService()
        {
            _paymentByCreditCard = new PaymentByCreditCard();
            _paymentByPaypal = new PaymentByPaypal();
            _wirePayment = new WirePayment();
        }

        public string MakePayment(decimal amount, PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.Paypal:
                    return _paymentByPaypal.PaymentviaPaypal(amount);
                case PaymentMethod.Wire:
                    return _wirePayment.PaymentviaWire(amount);
                case PaymentMethod.CreditCard:
                    return _paymentByCreditCard.PaymentviaCreditCard(amount);
                default:
                    return "Payment was not made.";
            }
        }
    }

    enum PaymentMethod
    {
        CreditCard = 1,
        Wire = 2,
        Paypal = 3
    }
}
