using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities {
    public class Student
    {
        private IList<Subscription> _subscriptions;

        public Student(string firstName, string lastName, string document, string mail)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Mail = mail;
            _subscriptions = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }
        
        public string Document { get; private set; }

        public string Mail { get; private set; }

        public string Address { get; private set; }
        
        public IReadOnlyCollection<Subscription> Subscriptions 
        {
            get 
            {
                return _subscriptions.ToArray();
            }
        }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Deactivate();

            _subscriptions.Add(subscription);
        }
    }
}