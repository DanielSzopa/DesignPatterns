namespace Proxy
{
    public class ProxyYoutubeService : IYoutubeService
    {
        private YoutubeService _youtubeService;
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public ProxyYoutubeService(YoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }

        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"ProxyYoutubeService getting {videoId}");
            byte[] cachedVideo;

            if (_cache.TryGetValue(videoId, out cachedVideo))
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return cachedVideo;
            }

            var video = _youtubeService.GetVideo(videoId);
            _cache.Add(videoId,video);

            return video;
        }
    }
}
