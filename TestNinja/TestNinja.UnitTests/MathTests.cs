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
    }
}
