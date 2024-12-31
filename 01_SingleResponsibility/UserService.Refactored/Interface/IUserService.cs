namespace _01_SingleResponsibility.UserService.Refactored.Interface
{
    interface IUserService
    {
        void Register();

        void Login(string mail, string password);

        void Logout();
    }
}
