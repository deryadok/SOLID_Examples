using _01_SingleResponsibility.UserService.Refactored.Interface;

namespace _01_SingleResponsibility.UserService.Refactored.Services
{
    class SMSService : ISendService
    {
        public void Send()
        {
            Console.WriteLine("SMS has been sent to your phone.");
        }
    }
}
