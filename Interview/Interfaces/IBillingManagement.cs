using Interview.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Interview.Interfaces
{
    interface IBillingManagement
    {
        public IActionResult Create(InvoiceRequest invoice);

        public IEnumerable<InvoiceResponse> GetAll();

        public ActionResult<InvoiceResponse> Get(Guid id);

        public IActionResult Update(Guid id, InvoiceRequest invoice);

        public IActionResult Delete(Guid id);
    }
}
