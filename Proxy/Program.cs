using Proxy;

//Normal executing
YoutubeService youtube = new YoutubeService();
youtube.GetVideo(10);
youtube.GetVideo(10);

//Proxy executing

IYoutubeService proxYoutubeService = new ProxyYoutubeService(youtube);
proxYoutubeService.GetVideo(10);
proxYoutubeService.GetVideo(10);

