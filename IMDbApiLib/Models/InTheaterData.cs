namespace IMDbApiLib.Models;

public class InTheaterData : ApiBaseModel
{
    public InTheaterData()
    {
    }

    public InTheaterData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public List<InTheaterDataItem> Items { get; set; } = [];
}

public class InTheaterDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public int RuntimeMins { get; set; }
    public string RuntimeStr { get; set; } = string.Empty;
    public string ContentRating { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public int MetacriticRating { get; set; }
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
}