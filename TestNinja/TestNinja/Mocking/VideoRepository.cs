
using System.Collections.Generic;
using System.Linq;


namespace TestNinja.Mocking
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnproccessedVideos();
    }

    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnproccessedVideos()
        {
            using (var context = new VideoContext())
            {
                var videos =
                       (from video in context.Videos
                        where !video.IsProcessed
                        select video).ToList();
                return videos;
            }


        }
    }
}
