using System;

namespace PaymentContext.Domain.Entities {
    public abstract class Payment
    {
        protected Payment(DateTime paidAtDate, 
                          DateTime dueDate, 
                          decimal total, 
                          decimal totalPaid, 
                          string payer, 
                          string docunent, 
                          string address, 
                          string mail)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10).ToUpper();
            PaidAtDate = paidAtDate;
            DueDate = dueDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Docunent = docunent;
            Address = address;
            Mail = mail;
        }

        public string Id { get; private set; }

        public DateTime PaidAtDate { get; private set; }

        public DateTime DueDate { get; private set; }

        public decimal Total { get; private set; }

        public decimal TotalPaid { get; private set; }

        public string Payer { get; private set; }
        
        public string Docunent { get; private set; }
        
        public string Address { get; private set; }

        public string Mail { get; private set; }
    }
}