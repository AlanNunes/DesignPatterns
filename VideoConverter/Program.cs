using System;

namespace VideoConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your username");
            string username = Console.ReadLine();
            Console.WriteLine("Type your E-mail");
            string email = Console.ReadLine();
            Console.WriteLine("Type your password");
            string password = Console.ReadLine();
            Console.WriteLine("Type your phone number");
            string phonenumber = Console.ReadLine();

            // Use Facade
            AuthFacade.Register(username, email, password, phonenumber);

            Console.ReadKey();
        }
    }
}
