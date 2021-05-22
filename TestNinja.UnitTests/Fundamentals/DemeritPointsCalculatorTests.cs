using NUnit.Framework;
using System;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)] // Min value is 0
        [TestCase(301)] // Max value is 300
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ResultException(int speed)
        {
            var demerit = new TestNinja.Fundamentals.DemeritPointsCalculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => demerit.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedLessThanSpeedLimit_ResultZero()
        {
            var demerit = new TestNinja.Fundamentals.DemeritPointsCalculator();
            var result = demerit.CalculateDemeritPoints(55);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(66,0)]
        [TestCase(65*2, 65/5)]
        [TestCase(65 * 3, (65*2)/5)]
        public void CalculateDemeritPoints_SpeedGreaterThanLimit_ResultDemeterPoints(int speed, int expectedValue)
        {
            var demerit = new TestNinja.Fundamentals.DemeritPointsCalculator();
            var result = demerit.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
