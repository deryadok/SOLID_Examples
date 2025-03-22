using _02_OpenClosedPrinciple.PaymentSystem;
using _02_OpenClosedPrinciple.PaymentSystem.Refactored;

Console.WriteLine("Enter the amount: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("For pay via Credit Card press 1");
Console.WriteLine("For pay via Wire press 2");
Console.WriteLine("For pay via Paypal press 3");
PaymentMethod paymentMethod = (PaymentMethod)Convert.ToInt32(Console.ReadLine());

#region Non-Refactored
//PaymentService paymentService = new PaymentService();
//string result = paymentService.MakePayment(amount, paymentMethod);
//Console.WriteLine(result);
#endregion

#region Refactored
PaymentServiceRefactored paymentService1 = new PaymentServiceRefactored(PaymentHelper.PaymentHelperMethod(paymentMethod));
string result1 = paymentService1.MakePayment(amount);
Console.WriteLine(result1);
#endregion

Console.ReadKey();

