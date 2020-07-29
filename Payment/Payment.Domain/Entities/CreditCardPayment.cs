using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime paidAtDate, 
                            DateTime dueDate, 
                            decimal total, 
                            decimal totalPaid, 
                            string payer, 
                            string docunent, 
                            string address, 
                            string mail,
                            string cardHolderName, 
                            string cardNumber, 
                            string lastTransactionNumber)
        : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, mail)
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