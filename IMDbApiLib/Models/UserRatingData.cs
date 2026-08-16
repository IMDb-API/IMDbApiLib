namespace IMDbApiLib.Models;

public class UserRatingData : ApiBaseModel
{
    public UserRatingData()
    {
    }

    public UserRatingData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public UserRatingData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public List<UserRatingDataItem> Ratings { get; set; } = [];
}

public class UserRatingDataItem
{
    public int Rating { get; set; }
    public decimal Percent { get; set; }
    public int Votes { get; set; }
}