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
    }
}
