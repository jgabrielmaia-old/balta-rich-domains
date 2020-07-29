using Payment.Domain.ValueObjects;
using Payment.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities {
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Guid id, Name name, Document document, Email email, Address address)
        : base(id)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        
        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public Address Address { get; private set; }
        
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