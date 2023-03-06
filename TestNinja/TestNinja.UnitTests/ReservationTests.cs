namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin= true });

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_SameUser_ReturnsTrue() 
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};
                                               
            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsDifferent_ReturnsFalse() 
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            //Assert
            Assert.IsFalse(result);
        }
    }
}