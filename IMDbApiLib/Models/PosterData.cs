namespace IMDbApiLib.Models;

public class PosterData : ApiBaseModel
{
    public PosterData()
    {
    }

    public PosterData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public PosterData(string id, string errorMessage)
    {
        ErrorMessage = errorMessage;
        IMDbId = id;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<PosterDataItem> Posters { get; set; } = [];
    public List<PosterDataItem> Backdrops { get; set; } = [];
}

public class PosterDataItem
{
    public string Url { get; set; } = string.Empty;
    public decimal AspectRatio { get; set; } = 0;
    public string Language { get; set; } = string.Empty;
    public int Width { get; set; } = 0;
    public int Height { get; set; } = 0;
}