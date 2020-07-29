using System;

namespace PaymentContext.Domain.Entities {
    public class InvoicePayment : Payment
    {
        public InvoicePayment(DateTime paidAtDate, 
                            DateTime dueDate, 
                            decimal total, 
                            decimal totalPaid, 
                            string payer, 
                            string docunent, 
                            string address, 
                            string mail,
                            string invoiceCode,
                            string barCode)
         : base(paidAtDate, dueDate, total, totalPaid, payer, docunent, address, mail)
        {
            InvoiceCode = invoiceCode;
            BarCode = barCode;
        }

        public string InvoiceCode { get; private set; }
        public string BarCode { get; private set; }

    }
}