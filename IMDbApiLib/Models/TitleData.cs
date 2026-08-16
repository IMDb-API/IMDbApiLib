namespace IMDbApiLib.Models;

public class TitleData : ApiBaseModel, ICloneable
{
    public TitleData()
    {
    }

    public TitleData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public TitleData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string OriginalTitle { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public string ReleaseDate { get; set; } = string.Empty;
    public int RuntimeMins { get; set; }
    public string RuntimeStr { get; set; } = string.Empty;
    public string Plot { get; set; } = string.Empty;
    public string PlotLocal { get; set; } = string.Empty;
    public bool PlotLocalIsRtl { get; set; } = false;
    public string Awards { get; set; } = string.Empty;
    public string Directors { get; set; } = string.Empty;
    public List<StarShort> DirectorList { get; set; } = [];
    public string Writers { get; set; } = string.Empty;
    public List<StarShort> WriterList { get; set; } = [];
    public string Stars { get; set; } = string.Empty;
    public List<StarShort> StarList { get; set; } = [];
    public List<ActorShort> ActorList { get; set; } = [];
    public FullCastData? FullCast { get; set; } = new();
    public string Genres { get; set; } = string.Empty;
    public List<KeyValueItem> GenreList { get; set; } = [];
    public string Companies { get; set; } = string.Empty;
    public List<CompanyShort> CompanyList { get; set; } = [];
    public string Countries { get; set; } = string.Empty;
    public List<KeyValueItem> CountryList { get; set; } = [];
    public string Languages { get; set; } = string.Empty;
    public List<KeyValueItem> LanguageList { get; set; } = [];
    public string ContentRating { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
    public int MetacriticRating { get; set; }
    public RatingData? Ratings { get; set; } = new();
    public WikipediaData? Wikipedia { get; set; } = new();
    public PosterData? Posters { get; set; } = new();
    public ImageData? Images { get; set; } = new();
    public TrailerData? Trailer { get; set; } = new();
    public BoxOfficeShort? BoxOffice { get; set; } = new();
    public string Keywords { get; set; } = string.Empty;
    public List<KeyValueItem> KeywordList { get; set; } = [];
    public List<MovieShort> Similars { get; set; } = [];
    public TvSeriesInfo? TvSeriesInfo { get; set; } = new();
    public TvEpisodeInfo? TvEpisodeInfo { get; set; } = new();

    public object Clone()
    {
        return MemberwiseClone();
    }
}

public class TvSeriesInfo
{
    public int YearEnd { get; set; }
    public string Creators { get; set; } = string.Empty;
    public List<StarShort> CreatorList { get; set; } = [];
    public List<string> Seasons { get; set; } = [];
}

public class TvEpisodeInfo
{
    public string SeriesId { get; set; } = string.Empty;
    public string SeriesTitle { get; set; } = string.Empty;
    public string SeriesFullTitle { get; set; } = string.Empty;
    public int SeriesYear { get; set; }
    public int SeriesYearEnd { get; set; }
    public int SeasonNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public string PreviousEpisodeId { get; set; } = string.Empty;
    public string NextEpisodeId { get; set; } = string.Empty;
}

public class MovieShort
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
}

public class StarShort
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public class BoxOfficeShort
{
    public string Budget { get; set; } = string.Empty;
    public long BudgetUsd { get; set; }
    public string OpeningWeekendUSA { get; set; } = string.Empty;
    public long OpeningWeekendUSAUsd { get; set; }
    public string GrossUSA { get; set; } = string.Empty;
    public long GrossUSAUsd { get; set; }
    public string CumulativeWorldwideGross { get; set; } = string.Empty;
    public long CumulativeWorldwideGrossUsd { get; set; }
}

public class CompanyShort
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}