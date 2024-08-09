namespace YTDownloaderDesktop.DTOs;

using System;
using System.Drawing;

public readonly struct YTInformation(string url, string title, string channelTitle, TimeSpan? duration, Bitmap? thumb)
{
    public string Url { get; } = url;
    public string Title { get; } = title;
    public string ChannelTitle { get; } = channelTitle;
    public TimeSpan? Duration { get; } = duration;
    public Bitmap? Thumb { get; } = thumb;
}
