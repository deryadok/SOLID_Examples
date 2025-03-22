namespace _02_OpenClosedPrinciple.PaymentSystem.Refactored
{
    internal class PaymentHelper
    {
        public static IPaymentService PaymentHelperMethod(PaymentMethod payment)
        {
            switch (payment)
            {
                case PaymentMethod.Paypal:
                    return new PaymentByPaypal();
                case PaymentMethod.Wire:
                    return new WirePayment();
                case PaymentMethod.CreditCard:
                    return new PaymentByCreditCard();
                default:
                    return null;
            }
        }
    }
}
