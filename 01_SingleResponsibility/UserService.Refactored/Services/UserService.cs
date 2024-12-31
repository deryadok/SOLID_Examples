using _01_SingleResponsibility.UserService.Refactored.Interface;

namespace _01_SingleResponsibility.UserService.Refactored.Services
{
    class UserService : IUserService
    {
        public void Login(string mail, string password)
        {
            Console.WriteLine($"You are logged in with {mail}");
        }

        public void Logout()
        {
            Console.WriteLine("You are logged out.");
        }

        public void Register()
        {
            Console.WriteLine("Your registration is completed.");
        }
    }
}
