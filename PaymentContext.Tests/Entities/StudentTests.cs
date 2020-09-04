using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            // var subscription = new Subscription();
            var student = new Student("Lucas", "Macêdo", "088.307.334-07", "l.alves001@gmail.com");
            // student.AddSubscription(subscription);
        }
    }
}