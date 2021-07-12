using DataServices.Models;
using Interview.Interfaces;
using Interview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using DataServices.Interfaces;

namespace Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class BillingController : ControllerBase , IBillingManagement
    {
        private readonly ILogger<BillingController> _logger;
        private readonly IInvoiceDataRepository _invoiceDataRepository;

        public BillingController(ILogger<BillingController> logger, 
                                 IInvoiceDataRepository invoiceDataRepository)
        {
            _logger = logger;
            _invoiceDataRepository = invoiceDataRepository;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(InvoiceRequest invoice)
        {           
            var invoiceData = new InvoiceDTO
            {
                Id = Guid.NewGuid(),
                ApplicationId = invoice.ApplicationId,
                Type = invoice.Type,
                Amount = invoice.Amount,
                Summary = invoice.Summary,
                PostingDate = invoice.PostingDate,
                ClearedDate = invoice.ClearedDate,
                IsCleared = invoice.IsCleared
            };

            _invoiceDataRepository.Create(invoiceData);

            return CreatedAtAction(nameof(Create), new { id = invoiceData.Id }, invoiceData );
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        // GET all action
        [HttpGet]
        public IEnumerable<InvoiceResponse> GetAll()
        {
            return _invoiceDataRepository.GetAll().Select(p => new InvoiceResponse
                    {                                 
                        Id = p.Id, ApplicationId = p.ApplicationId, 
                        Type = p.Type, 
                        Summary = p.Summary, 
                        Amount = p.Amount, ClearedDate = p.ClearedDate, 
                        IsCleared = p.IsCleared, PostingDate = p.PostingDate 
                     });
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<InvoiceResponse> Get(Guid id)
        {
            var invoice = _invoiceDataRepository.Get(id);

            if (invoice == null)
                return NotFound();

            var invoiceResponse = new InvoiceResponse
            {
                Id = invoice.Id,
                ApplicationId = invoice.ApplicationId,
                Type = invoice.Type,
                Summary = invoice.Summary,
                Amount = invoice.Amount,
                ClearedDate = invoice.ClearedDate,
                IsCleared = invoice.IsCleared,
                PostingDate = invoice.PostingDate
            };

            return invoiceResponse;
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, InvoiceRequest invoice)
        {
            throw new NotImplementedException();
        }
    }
}
