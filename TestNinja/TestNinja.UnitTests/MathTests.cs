using NUnit.Framework;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            //Arrange
            var math = new Fundamentals.Math();
            //Act
            var result = math.Add(1,2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument() 
        {
            //Arrange
            var math = new Fundamentals.Math();

            //Act
            var result = math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //Arrange
            var math = new Fundamentals.Math();

            //Act
            var result = math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            //Arrange
            var math = new Fundamentals.Math();

            //Act
            var result = math.Max(1, 1);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
