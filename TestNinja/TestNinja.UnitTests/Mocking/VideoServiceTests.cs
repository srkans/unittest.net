using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
   

    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _videoRepository;
        private VideoService _videoService;

        [SetUp]
        public void SetUp() 
        {
            _fileReader= new Mock<IFileReader>();
            _videoRepository= new Mock<IVideoRepository>();
            _videoService= new VideoService(_fileReader.Object, _videoRepository.Object);
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

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosAreProcessed_ReturnEmptyString() 
        {
            _videoRepository.Setup(r => r.GetUnproccessedVideos()).Returns(new List<Video>());

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
        }
    }
}
