using FluentValidator.Validation;
using Student.NotificationPattern.ValueObjects;

namespace Student.NotificationPattern.Validations
{
    public class EmailValidationContract : IContract
    {
        public ValidationContract Contract { get; }

        public EmailValidationContract(Email email)
        {
            Contract = new ValidationContract();
            Contract.Requires().IsEmail(email.email, "email", "The E-mail is invalid");
        }
    }
}
