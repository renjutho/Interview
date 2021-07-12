using System;

namespace DataServices.Models
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


    public class InvoiceDTO
    {
        public Guid Id { get; set; }
        public int ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public decimal Amount { get; set; }
        public DateTime PostingDate { get; set; }
        public bool IsCleared { get; set; }
        public DateTime? ClearedDate { get; set; }
    }
}
