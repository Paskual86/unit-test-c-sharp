using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(1,2,3)]
        [Ignore("Porque si!")]
        public void Add_WhenExecuted_ResultSumValues(int a, int b, int expectedResult) 
        {
            //Arrange
            //var math = new Math();
            //Act
            var result = _math.Add(a, b);
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
            //var math = new Math();
            // Act
            var result = _math.Max(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimits()
        {
            // Devuelve un array
            var result = _math.GetOddNumbers(5);

            // Chequeamos que no este vacio
            // Assert.That(result, Is.Not.Empty);
            // O chequeamos que la cantidad devuelta sea 3
            // Assert.That(result.Count(), Is.EqualTo(3));
            // O chequeamos los valores
            /*Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));*/

            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));

            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
        }
    }
}
