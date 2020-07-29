using System;
using Payment.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities {
    public class InvoicePayment : Payment
    {
        public InvoicePayment(DateTime paidAtDate,
                              DateTime dueDate,
                              decimal total,
                              decimal totalPaid,
                              string payer,
                              Document docunent,
                              Address address,
                              Email email,
                              string invoiceCode,
                              string barCode)
         : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, email)
        {
            InvoiceCode = invoiceCode;
            BarCode = barCode;
        }

        public string InvoiceCode { get; private set; }
        public string BarCode { get; private set; }

    }
}