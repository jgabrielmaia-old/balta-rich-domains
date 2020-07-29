using System;

namespace PaymentContext.Domain.Entities {
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(DateTime paidAtDate, 
                        DateTime dueDate, 
                        decimal total, 
                        decimal totalPaid, 
                        string payer, 
                        string docunent, 
                        string address, 
                        string mail,
                        string transactionCode)
            : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, mail)
        {
            TransactionCode = transactionCode;
        }
    }
}