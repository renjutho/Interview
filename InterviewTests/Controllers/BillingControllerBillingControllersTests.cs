using DataServices.Interfaces;
using Interview.Controllers;
using Interview.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace InterviewTests.Controllers
{
    public class BillingControllerBillingControllersTests
    {
        [Fact]       
        public void CreateReturnsActionResultSuccessWithValidRequest()
        {
            //Arrange
            var mockInvoiceDataRepo = new Mock<IInvoiceDataRepository>();
            
            var controller = new BillingController(null, mockInvoiceDataRepo.Object);

            //Act
            var result =  controller.Create(new InvoiceRequest
            {
                ApplicationId = 123,
                Type = "Debit",
                Summary = "Refund",
                Amount = 100,
                PostingDate = DateTime.Today.AddDays(-5).Date,
                ClearedDate = DateTime.Today,
                IsCleared = false
            });

            //Assert
            Assert.IsType<CreatedAtActionResult>(result);           

        }

    }
}
