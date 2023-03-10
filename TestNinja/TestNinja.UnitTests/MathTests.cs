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
        [Ignore("istedigim testi gormezden gelip buraya bir aciklama yazabilirim")]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            //Arrange
            
            //Act
            var result = _math.Add(1,2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2,1,2)] //a,b,expectedResult
        [TestCase(1,2,2)]
        [TestCase(1,1,1)] //MSTests Expects csv files or excel sheet doesn't accept like this
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b,int expectedResult) 
        {
            //Arrange
            

            //Act
            var result = _math.Max(a,b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit() 
        {
           var result = _math.GetOddNumbers(5);

            // Assert.That(result, Is.Not.Empty);

            //Assert.That(result.Count(),Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);

            Assert.That(result, Is.Unique);
        }

        
    }
}
