using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        [TestCase(1,2,3)]
        [Ignore("Porque si!")]
        public void Add_WhenExecuted_ResultSumValues(int a, int b, int expectedResult) 
        {
            //Arrange
            var math = new Math();
            //Act
            var result = math.Add(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenExecuted_ResultTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Arrange
            var math = new Math();
            // Act
            var result = math.Max(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
