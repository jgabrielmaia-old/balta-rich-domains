using System;
using Flunt.Validations;
using Payment.Domain.ValueObjects;
using Payment.Shared.Entities;

namespace PaymentContext.Domain.Entities {
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidAtDate, 
                          DateTime dueDate, 
                          decimal total, 
                          decimal totalPaid, 
                          string payer, 
                          Document docunent, 
                          Address address, 
                          Email email)
        {
            InvoiceId = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10).ToUpper();
            PaidAtDate = paidAtDate;
            DueDate = dueDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Docunent = docunent;
            Address = address;
            Email = email;

            AddNotifications(new Contract()
                            .Requires()
                            .IsGreaterThan(0, Total, "Payment.Total", "The payment value is equal or less than zero")
                            .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.TotalPaid", "The total paid is equal or less than the payment value.")); 
        }

        public string InvoiceId { get; private set; }

        public DateTime PaidAtDate { get; private set; }

        public DateTime DueDate { get; private set; }

        public decimal Total { get; private set; }

        public decimal TotalPaid { get; private set; }

        public string Payer { get; private set; }
        
        public Document Docunent { get; private set; }
        
        public Address Address { get; private set; }

        public Email Email { get; private set; }
    }
}