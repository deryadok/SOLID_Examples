namespace _02_OpenClosedPrinciple.PaymentSystem.Refactored
{
    internal interface IPaymentService
    {
        string MakePayment(decimal amount);
    }
}
