using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
 
    [TestFixture]
    public class FizzBuzzTests
    {
 
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzz_CanDivideByBoth_ReturnFizzBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void FizzBuzz_CanDivideByThree_ReturnFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void FizzBuzz_CanDivideByFive_ReturnBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4,"4")]
        [TestCase(7,"7")]
        public void FizzBuzz_CantDivideByAny_ReturnItself(int number, string expectedValue)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
