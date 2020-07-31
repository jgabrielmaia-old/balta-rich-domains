using Flunt.Validations;
using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 2, "Name.FirstName", "Name should have at least 3 characters")
                .HasMinLen(LastName, 2, "Name.FirstName", "Surname should have at least 3 characters")
                .HasMaxLen(FirstName, 50, "Name.FirstName", "Name should have a maximum of 50 characters")
                .HasMaxLen(LastName, 50, "Name.FirstName", "Surname should have a maximum of 50 characters")  
            );
        }
     
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}