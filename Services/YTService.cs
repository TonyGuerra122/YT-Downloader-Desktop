using System.IO.Packaging;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YTDownloaderDesktop.DTOs;
using YTDownloaderDesktop.Environment;

namespace YTDownloaderDesktop.Services;

public class YTService
{
    private static readonly HttpClient HttpClient = new();
    private readonly YoutubeClient YoutubeClient;

    public YTService()
    {
        YoutubeClient = new YoutubeClient();
    }

    public async Task<YTInformation?> GetVideoInformation(string url)
    {
        try
        {
            var video = await YoutubeClient.Videos.GetAsync(url);

            var thumb = video.Thumbnails[0].Url;

            var thumbImage = await LoadThumb(thumb);

            return new YTInformation(url, video.Title, video.Author.ChannelTitle, video.Duration, thumbImage);
        }
        catch (Exception)
        {
            return null;
        }
    }
    public async Task DownloadVideo(string url, bool audioOnly)
    {
        var videoInfo = await GetVideoInformation(url) ?? throw new Exception("Vídeo não encontrado");

        var streamManifest = await YoutubeClient.Videos.Streams.GetManifestAsync(url);

        IStreamInfo? streamInfo;

        if (audioOnly) 
        {
            streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
        } else
        {
            streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
        }

        var filePath = Path.Combine(Constants.DownloadsFolder, $"{videoInfo.Title}.{streamInfo.Container}");

        await YoutubeClient.Videos.Streams.DownloadAsync(streamInfo, filePath);
    }

    private static async Task<Bitmap?> LoadThumb(string url)
    {
        try
        {
            url = url.Split('?')[0];

            byte[] imageData = await HttpClient.GetByteArrayAsync(url);

            using var memStream = new MemoryStream(imageData);

            return new Bitmap(memStream);
        }
        catch (Exception)
        {
            MessageBox.Show(url);
            return null;
        }
    }

}
