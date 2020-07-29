using PaymentContext.Domain.Entities;
using Xunit;

namespace PaymentContext.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            var subscription = new Subscription(null);
            var student = new Student(firstName:"Andre", lastName:"Baltieri", document:"288.062.820-26", mail:"samplemail@mail.com");
            student.AddSubscription(subscription);
            
            Assert.NotNull(student);
            Assert.NotNull(student.Subscriptions);
        }
    }
}
