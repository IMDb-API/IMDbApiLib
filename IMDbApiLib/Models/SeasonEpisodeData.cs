namespace IMDbApiLib.Models;

public class SeasonEpisodeData : ApiBaseModel
{
    public SeasonEpisodeData()
    {
    }

    public SeasonEpisodeData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public SeasonEpisodeData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public SeasonEpisodeData(string id, string title, string titleFull, string type, string errorMessage)
    {
        IMDbId = id;
        Title = title;
        FullTitle = titleFull;
        Type = type;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public int TotalEpisodes { get; set; }
    public List<SeasonEpisodeDataItem> Episodes { get; set; } = [];
}

public class SeasonEpisodeDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public int SeasonNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public string Released { get; set; } = string.Empty;
    public string Plot { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
}