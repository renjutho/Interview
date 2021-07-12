using DataServices.Models;
using System;
using System.Collections.Generic;

namespace DataServices.Interfaces
{
    public interface IInvoiceDataRepository
    {
        public void Create(InvoiceDTO invoiceData);
        public IEnumerable<InvoiceDTO> GetAll();
        public InvoiceDTO Get(Guid id);
        public void Update(Guid id, InvoiceDTO invoice);
        public void Delete(Guid id);

    }
}
