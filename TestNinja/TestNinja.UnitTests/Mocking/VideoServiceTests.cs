using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{

    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {
            var service = new VideoService();

            service.FileReader = new FakeFileReader(); //constructor'da FileReader sınıfını atamıştım null kalmasın diye.

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);

        }
    }
}
