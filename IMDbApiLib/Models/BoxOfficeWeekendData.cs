namespace IMDbApiLib.Models;

public class BoxOfficeWeekendData : ApiBaseModel
{
    public BoxOfficeWeekendData()
    {
    }

    public BoxOfficeWeekendData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string StartDate { get; set; } = string.Empty;
    public string EndDate { get; set; } = string.Empty;
    public List<BoxOfficeWeekendDataItem> Items { get; set; } = [];
}

public class BoxOfficeWeekendDataItem
{
    public int Rank { get; set; }
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public string Crew { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public string WeekendGross { get; set; } = string.Empty;
    public long WeekendGrossUsd { get; set; }
    public string TotalGross { get; set; } = string.Empty;
    public long TotalGrossUsd { get; set; }
    public int WeeksReleased { get; set; }
}