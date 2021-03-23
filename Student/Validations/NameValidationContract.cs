using FluentValidator.Validation;
using Student.NotificationPattern.ValueObjects;

namespace Student.NotificationPattern.Validations
{
    public class NameValidationContract : IContract
    {
        public ValidationContract Contract { get; }
        public NameValidationContract(Name name)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .HasMinLen(name.FirstName, 3, "FirstName", "The first name must have at least 3 characters");
            Contract
                .Requires()
                .HasMaxLen(name.LastName, 50, "FirstName", "The first name must be up to 50 characters");
            Contract
                .Requires()
                .HasMinLen(name.LastName, 3, "LastName", "The first name must have at least 3 characters");
            Contract
                .Requires()
                .HasMaxLen(name.LastName, 50, "LastName", "The first name must be up to 50 characters");
        }
    }
}
