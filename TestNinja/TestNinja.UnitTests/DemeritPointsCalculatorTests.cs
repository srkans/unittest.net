using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
    

        [Test]
        public void CalculateDemeritPoints_SpeedSmallerThanZero_ThrowException() 
        {
          var calculator = new DemeritPointsCalculator();

          Assert.That(() => calculator.CalculateDemeritPoints(-1),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(69,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemerit(int speed, int expectedResult) 
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

             
        [Test]
        public void CalculateDemeritPoints_SpeedGreaterThan300_ThrowException() 
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
