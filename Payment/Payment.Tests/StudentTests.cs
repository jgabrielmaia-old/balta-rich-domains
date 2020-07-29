using System;
using PaymentContext.Domain.Entities;
using Payment.Domain.ValueObjects;
using Xunit;
using Payment.Domain.Enums;

namespace PaymentContext.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            var guid = Guid.NewGuid();
            var name = new Name("Andre", "Baltieri");
            var document = new Document("288.062.820-26", EDocumentType.Cpf);
            var email = new Email("samplemail@mail.com");
            var address = new Address("Avenue Boulevard", "1008","St. Mathew","Juiz de Fora","Minas Gerais","Brazil","36016011");
            var subscription = new Subscription(null);   
            var student = new Student(guid, name, document, email, address);

            student.AddSubscription(subscription);
            
            Assert.NotNull(student);
            Assert.NotNull(student.Subscriptions);
        }
    }
}
