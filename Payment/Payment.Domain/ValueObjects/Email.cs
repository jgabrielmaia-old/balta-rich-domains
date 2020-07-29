using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;             
        }

        public string Address { get; set; }
    }
}