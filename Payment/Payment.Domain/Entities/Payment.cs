using System;
using Payment.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {
    public abstract class Payment
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
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10).ToUpper();
            PaidAtDate = paidAtDate;
            DueDate = dueDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Docunent = docunent;
            Address = address;
            Email = email;
        }

        public string Id { get; private set; }

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