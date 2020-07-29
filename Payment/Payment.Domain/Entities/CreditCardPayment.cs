using System;
using Payment.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime paidAtDate,
                                 DateTime dueDate,
                                 decimal total,
                                 decimal totalPaid,
                                 string payer,
                                 Document docunent,
                                 Address address,
                                 Email email,
                                 string cardHolderName,
                                 string cardNumber,
                                 string lastTransactionNumber)
        : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }

        public string CardNumber { get; private set; }

        public string LastTransactionNumber { get; private set; }

    }
}