using Payment.Shared.ValueObjects;

namespace Payment.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            if(string.IsNullOrEmpty(firstName))
                AddNotification("Name.FirstName", "Primeiro nome invalido");

            if(string.IsNullOrEmpty(firstName))
                AddNotification("Name.LastName", "Sobrenome invalido");
        }
     
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}