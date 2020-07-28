using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities {
    public class Subscription 
    {
        public DateTime CreationDate { get; set; }
        
        public DateTime LastUpdateDate { get; set; }
        
        public DateTime? DueDate { get; set; }

        public bool Active { get; set; }

        public List<Payment> Payments { get; set; }
    }
}