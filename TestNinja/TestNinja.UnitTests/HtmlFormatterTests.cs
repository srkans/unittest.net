using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement() 
        {
            //Arrange
            var formatter = new HtmlFormatter();
            //Act
            var result = formatter.FormatAsBold("abc");
            //Assert
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>")); //specific way

            Assert.That(result, Does.StartWith("<strong>")); //more general way
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result,Does.Contain("abc").IgnoreCase);
            //case sensitive-- iptal etmek icin ignorecase
        }
    }
}
