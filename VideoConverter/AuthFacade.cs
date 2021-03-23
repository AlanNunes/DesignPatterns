using System;
using System.Collections.Generic;
using System.Text;
using VideoConverter.AuthLibrary;

namespace VideoConverter
{
    public class AuthFacade
    {
        public static void Register(string username, string email, string password, string phonenumber)
        {
            User user = new User()
            {
                UserName = username,
                Email = email,
                Password = password,
                PhoneNumber = phonenumber
            };
            Authenticator.Register(user);
            int token = Authenticator.Login(user.Email, user.Password);
            Authenticator.SendEmailConfirmation(user);
        }
        public static void Login(string email, string password)
        {
            Authenticator.Login(email, password);
        }
    }
}
