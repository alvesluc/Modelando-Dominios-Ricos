using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Lucas";
            command.LastName = "Alves";
            command.Document = "12345678910";
            command.Email = "l.alves001@gmail.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "1234567890";
            command.PaymentNumber = "123123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 70;
            command.TotalPaid = 70;
            command.Payer = "LucasSAAS";
            command.PayerDocument = "12345678910";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "l.alves001@gmail.com";
            command.Street = "Rua Arrumada";
            command.Number = "89";
            command.Neighborhood = "Centro";
            command.City = "João Pessoa";
            command.State = "PB";
            command.Country = "BR";
            command.ZipCode = "55867746";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}