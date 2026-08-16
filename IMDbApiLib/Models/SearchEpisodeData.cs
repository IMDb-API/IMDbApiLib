namespace IMDbApiLib.Models;

public class SearchEpisodeData : ApiBaseModel
{
    public SearchEpisodeData()
    {
    }

    public SearchEpisodeData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchEpisodeDataItem> Items { get; set; } = [];
}

public class SearchEpisodeDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public int RuntimeMins { get; set; }
    public string RuntimeStr { get; set; } = string.Empty;
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public string Plot { get; set; } = string.Empty;

    public SearchEpisodeDataItemSeries Series { get; set; } = new();
}

public class SearchEpisodeDataItemSeries
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
}