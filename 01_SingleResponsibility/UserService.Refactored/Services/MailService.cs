using _01_SingleResponsibility.UserService.Refactored.Interface;

namespace _01_SingleResponsibility.UserService.Refactored.Services
{
    class MailService : ISendService
    {
        public void Send()
        {
            Console.WriteLine("Mail has been sent to your mail.");
        }
    }
}
