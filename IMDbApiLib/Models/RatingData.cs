namespace IMDbApiLib.Models;

public class RatingData : ApiBaseModel
{
    public RatingData()
    {
    }

    public RatingData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public RatingData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal IMDb { get; set; }
    public int Metacritic { get; set; }
    public int TheMovieDb { get; set; }
    public int RottenTomatoes { get; set; }
    public decimal FilmAffinity { get; set; }
}