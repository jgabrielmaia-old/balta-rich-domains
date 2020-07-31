using Flunt.Validations;
using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new Contract().Requires().IsEmail(address, "Email.Address", "Invalid e-mail!"));
        }

        public string Address { get; set; }
    }
}