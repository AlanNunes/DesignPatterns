using System;
using System.Collections.Generic;
using System.Text;

namespace VideoConverter.AuthLibrary
{
    public static class Authenticator
    {
        public static void Register(User user)
        {
            Console.WriteLine($"{user.UserName} registered successfully!");
        }
        public static int Login(string email, string password)
        {
            Console.WriteLine($"{email} has logged in successfully.");
            return HashCode.Combine(email, password);
        }
        public static bool IsUserLockedout(int token)
        {
            User user = Authenticator.GetUserByToken(token);
            return user.LockedoutEnabled;
        }
        public static void AddTwoFactorAuth(int token, string authType)
        {
            User user = Authenticator.GetUserByToken(token);
            if (authType == "PhoneNumber")
                Console.WriteLine($"Phone number '{user.PhoneNumber}' two factor authenticator added successfully.");
            else if (authType == "Email")
                Console.WriteLine($"E-mail '{user.Email}' two factor authenticator added successfully.");
            else
                Console.WriteLine($"{authType} is a not supported two factor authenticator");
        }
        public static User GetUserByToken(int token)
        {
            return new User();
        }
        public static void SendEmailConfirmation(User user)
        {
            Console.WriteLine($"E-mail confirmation sent to {user.Email}");
        }
    }
}
