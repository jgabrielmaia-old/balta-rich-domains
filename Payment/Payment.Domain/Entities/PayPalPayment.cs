using System;
using Payment.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {
    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(DateTime paidAtDate,
                             DateTime dueDate,
                             decimal total,
                             decimal totalPaid,
                             string payer,
                             Document docunent,
                             Address address,
                             Email email,
                             string transactionCode)
            : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, email)
        {
            TransactionCode = transactionCode;
        }
    }
}