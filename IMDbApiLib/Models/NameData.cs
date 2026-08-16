namespace IMDbApiLib.Models;

public class NameData : ApiBaseModel
{
    public NameData()
    {
    }

    public NameData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public NameData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string AlternativeNames { get; set; } = string.Empty;
    public string Professions { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string BirthDate { get; set; } = string.Empty;
    public string DeathDate { get; set; } = string.Empty;
    public string Awards { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;
    public string Spouse { get; set; } = string.Empty;
    public List<NameDataKnownFor> KnownFor { get; set; } = [];
    public List<NameDataMovie> CastMovies { get; set; } = [];
}

public class NameDataMovie
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
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
    public string ProductionStatus { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string AsCharacter { get; set; } = string.Empty;
}

public class NameDataKnownFor
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
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
    public string Role { get; set; } = string.Empty;
    public string AsCharacter { get; set; } = string.Empty;
}