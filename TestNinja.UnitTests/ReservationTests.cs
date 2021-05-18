using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        private Reservation _reservation;
        
        [SetUp]
        public void Setup()
        {
            _reservation = new Reservation();
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ResultsTrue()
        {
            // Arrange
            
            // Act
            var result = _reservation.CanBeCancelledBy(new User() { IsAdmin = true });
            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserNotIsAdmin_ResultsFalse()
        {
            // Arrange

            // Act
            var result = _reservation.CanBeCancelledBy(new User() { IsAdmin = false });
            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ResultsTrue()
        {
            // Arrange
            var user = new User();
            _reservation.MadeBy = user;
            // Act
            var result = _reservation.CanBeCancelledBy(user);
            // Assert
            Assert.IsTrue(result);
        }
    }
}