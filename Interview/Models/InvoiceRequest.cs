using System;

namespace Interview.Models
{
    //public enum InvoiceType
    //{ 
    //    Debit,
    //    Credit
    //}

    //public enum InvoiceSummary
    //{
    //    Payment,
    //    Refund
    //}


    public class InvoiceRequest
    {
        public Guid Id { get; }
        public int ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public decimal Amount { get; set; }
        public DateTime PostingDate { get; set; }
        public bool IsCleared { get; set; }
        public DateTime? ClearedDate { get; set; }
    }
}
