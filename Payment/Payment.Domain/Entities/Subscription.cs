using System;
using System.Collections.Generic;
using Flunt.Validations;
using Payment.Shared.Entities;

namespace PaymentContext.Domain.Entities {
    public class Subscription : Entity
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? dueDate)
        {
            CreationDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            DueDate = dueDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreationDate { get; private set; }
        
        public DateTime LastUpdateDate { get; private set; }
        
        public DateTime? DueDate { get; private set; }

        public bool Active { get; private set; }

        public IReadOnlyCollection<Payment> Payments { get; private set; } 

        public void AddPayment(Payment payment) 
        {
            AddNotifications(new Contract()
                            .Requires()
                            .IsGreaterThan(DateTime.Now, payment.PaidAtDate, "Subscriptions.Payment", "The payment is late."));
            _payments.Add(payment);
        } 

        public void Activate()
        {
            Active = true;
            Updated();
        }

        public void Deactivate()
        {
            Active = false;
            Updated();
        }

        private void Updated()
        {
            LastUpdateDate = DateTime.Now;
        }
    }
}