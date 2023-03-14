using Moq;
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
            var fileReader = new Mock<IFileReader>();

            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            //filereader read methodunu ilgili argument ile çağırdığımda boş bir string döndürecek bir mock set ettik.
            //moq documentetion araştır.
            //use moq for only external dependencies
            var service = new VideoService(fileReader.Object);

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);

        }
    }
}
