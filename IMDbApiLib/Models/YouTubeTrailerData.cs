namespace IMDbApiLib.Models;

public class YouTubeTrailerData : ApiBaseModel
{
    public YouTubeTrailerData()
    {
    }

    public YouTubeTrailerData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public YouTubeTrailerData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string VideoId { get; set; } = string.Empty;
    public string VideoUrl { get; set; } = string.Empty;
}