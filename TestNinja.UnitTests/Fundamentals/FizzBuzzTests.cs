using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        [TestCase(25, "Buzz")]
        [TestCase(4, "4")]
        public void GetOutput_WhenIsCalled_ResultsTheExpectedValues(int value, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(value);
            Assert.That(result, Is.EqualTo(expectedResult).IgnoreCase);
        }
    }
}
