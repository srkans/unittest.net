using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        //SetUp
        //TearDown

        [SetUp]
        public void YenidenOlustur() 
        {
            _math = new Fundamentals.Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            //Arrange
            
            //Act
            var result = _math.Add(1,2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument() 
        {
            //Arrange
            

            //Act
            var result = _math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //Arrange
            

            //Act
            var result = _math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            //Arrange
            

            //Act
            var result = _math.Max(1, 1);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
