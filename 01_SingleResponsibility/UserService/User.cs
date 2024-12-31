namespace _01_SingleResponsibility.UserService
{
    //Bu class içerisinde yazılan işlemlerin hepsi User ile ilgili olsa da tek bir class içerisinde yazılması SRP'ye uygun değildir.
    //Bu nedenle farklı sorumluluklar farklı classlar içerisinde olmalıdır.

    class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public void Register()
        {
            Console.WriteLine("Your registration is completed.");
        }

        public void Login(string mail, string password)
        {
            Console.WriteLine($"You are logged in with {mail}");
        }

        public void Logout()
        {
            Console.WriteLine("You are logged out.");
        }

        public void SendMail()
        {
            Console.WriteLine("Mail has been sent to your mail.");
        }

        public void SendSms()
        {
            Console.WriteLine("SMS has been sent to your phone.");
        }

        public void ChangePassword()
        {
            Console.WriteLine("Your password has been changed.");
        }
    }
}