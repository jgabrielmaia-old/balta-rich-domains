using System;

namespace PaymentContext.Domain.Entities {
    public abstract class Payment
    {
        public int Number { get; set; }

        public DateTime PaidAtDate { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; }

        public string Payer { get; set; }
        
        public string Docunent { get; set; }
        
        public string Address { get; set; }

        public string Mail { get; set; }
    }
}