using FluentValidator.Validation;
using Student.NotificationPattern.Validations;
using Student.NotificationPattern.ValueObjects;
using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Type your email name: ");
            string email = Console.ReadLine();
            Name name = new Name(firstName, lastName);
            Email emailObj = new Email(email);
            NameValidationContract nameValidation = new NameValidationContract(name);
            EmailValidationContract emailValidation = new EmailValidationContract(emailObj);
            ValidationContract validation = new ValidationContract();
            validation.AddNotifications(nameValidation.Contract.Notifications);
            validation.AddNotifications(emailValidation.Contract.Notifications);
            foreach (var notification in validation.Notifications)
            {
                Console.WriteLine($"{notification.Property} : {notification.Message}");
            }
        }
    }
}
