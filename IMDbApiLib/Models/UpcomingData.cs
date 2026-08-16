namespace IMDbApiLib.Models;

public class UpcomingData : ApiBaseModel
{
    public UpcomingData()
    {
    }

    public UpcomingData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public List<UpcomingDataItem> Items { get; set; } = [];
}

public class UpcomingDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public string ReleaseDate { get; set; } = string.Empty;
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
    public string Stars { get; set; } = string.Empty;
    public List<StarShort> StarList { get; set; } = [];
}