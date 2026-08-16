namespace IMDbApiLib.Models;

public class SearchTitleData : ApiBaseModel
{
    public SearchTitleData()
    {
    }

    public SearchTitleData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchTitleDataItem> Items { get; set; } = [];
}

public class SearchTitleDataItem
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
    public string ContentRating { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public int MetacriticRating { get; set; }
    public string Plot { get; set; } = string.Empty;
}