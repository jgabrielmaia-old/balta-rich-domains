namespace PaymentContext.Domain.Entities {
    public class InvoicePayment : Payment
    {
        public string Number { get; set; }
        public string BarCode { get; set; }

    }
}