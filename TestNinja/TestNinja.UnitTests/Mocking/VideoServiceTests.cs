using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
   

    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;

        [SetUp]
        public void SetUp() 
        {
            _fileReader= new Mock<IFileReader>();
            _videoService= new VideoService(_fileReader.Object);
        }


        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {        

            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            //filereader read methodunu ilgili argument ile çağırdığımda boş bir string döndürecek bir mock set ettik.
            //moq documentetion araştır.
            //use moq for only external dependencies
       

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);

        }
    }
}
