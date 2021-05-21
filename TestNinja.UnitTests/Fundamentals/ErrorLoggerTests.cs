using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenIsCalled_ResultsLastErrorCode()
        {
            var log = new ErrorLogger();
            log.Log("error");
            Assert.That(log.LastError, Is.EqualTo("error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var log = new ErrorLogger();
            Assert.That(() => log.Log(error), Throws.ArgumentNullException);
            // Otra forma para excepciones mas generales
            //Assert.That(() => log.Log(error), Throws.Exception.TypeOf<DivideByZeroException>);
        }
    }
}
