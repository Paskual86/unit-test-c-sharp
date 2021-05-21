using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(0);
            //Assert
            Assert.That(result, Is.TypeOf<NotFound>());
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(1);
            //Assert
            Assert.That(result, Is.TypeOf<Ok>());
           // Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
