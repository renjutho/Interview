using DataServices.Models;
using DataServices.Resources;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DataServices
{
    public class InvoiceDataRepository : Interfaces.IInvoiceDataRepository
    {
        public List<InvoiceDTO> InvoiceData { get;  }

        

        public InvoiceDataRepository()
        {
            //var options = new JsonSerializerOptions();
            //var enumConvert = new JsonStringEnumConverter();            
            //options.Converters.Add(enumConvert);

            InvoiceData = JsonSerializer.Deserialize<List<InvoiceDTO>>(InterviewData.InvoiceJson);
        }

        public void Create(InvoiceDTO invoiceData)
        {
            invoiceData.Id = Guid.NewGuid();
            InvoiceData.Add(invoiceData);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDTO> GetAll()
        {
            return InvoiceData;
        }

        public InvoiceDTO Get(Guid Id) => InvoiceData.Find(p => p.Id == Id);


        public void Update(Guid id, InvoiceDTO invoice)
        {
            throw new NotImplementedException();
        }
    }
}
