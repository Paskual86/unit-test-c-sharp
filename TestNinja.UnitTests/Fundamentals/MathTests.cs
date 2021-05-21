using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenIsExecuted_ReturnTheValue() 
        {
            //Arrange
            var math = new Math();
            //Act
            var result = math.Add(1, 2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            // Arrange
            int a = 2, b = 1;
            var math = new Math();
            // Act
            var result = math.Max(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(a));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            // Arrange
            int a = 1, b = 2;
            var math = new Math();
            // Act
            var result = math.Max(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            // Arrange
            int c = 3;
            var math = new Math();
            int b;
            int a = b = c;
            // Act
            var result = math.Max(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(c));
        }
    }
}
