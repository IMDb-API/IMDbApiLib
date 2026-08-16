namespace IMDbApiLib.Models;

public class TrailerData : ApiBaseModel
{
    public TrailerData()
    {
    }

    public TrailerData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public TrailerData(string id, string errorMessage)
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
    public string VideoTitle { get; set; } = string.Empty;
    public string VideoDescription { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
    public string UploadDate { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public string LinkEmbed { get; set; } = string.Empty;
}