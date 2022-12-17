using System;
using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class TitleData : ICloneable
    {
        public TitleData()
        {
            ErrorMessage = string.Empty;
            DirectorList = new List<StarShort>();
            WriterList = new List<StarShort>();
            StarList = new List<StarShort>();
            ActorList = new List<ActorShort>();
            FullCast = new FullCastData();

            GenreList = new List<KeyValueItem>();
            CompanyList = new List<CompanyShort>();
            CountryList = new List<KeyValueItem>();
            LanguageList = new List<KeyValueItem>();

            Posters = new PosterData();
            Images = new ImageData();

            KeywordList = new List<string>();

            BoxOffice = new BoxOfficeShort();
            Similars = new List<SimilarShort>();

            TvSeriesInfo = new TvSeriesInfo();
            TvEpisodeInfo = new TvEpisodeInfo();

            Ratings = new RatingData();
            Wikipedia = new WikipediaData();

            Writers = Directors = Stars = Companies = Countries = Genres = Keywords = Languages = string.Empty;
        }

        public TitleData(string id, string errorMessage)
        {
            ErrorMessage = errorMessage;
            Id = id;
        }

        public string Id { get; set; }
        public string Title { set; get; }
        public string OriginalTitle { get; set; }
        public string FullTitle { set; get; }
        public string Type { set; get; }
        public string Year { set; get; }
        public string Image { get; set; }
        public string ReleaseDate { set; get; }
        public string RuntimeMins { set; get; }
        public string RuntimeStr { set; get; }
        public string Plot { set; get; }
        public string PlotLocal { set; get; }
        public bool PlotLocalIsRtl { set; get; }
        public string Awards { set; get; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public string Writers { set; get; }
        public List<StarShort> WriterList { get; set; }
        public string Stars { set; get; }
        public List<StarShort> StarList { get; set; }
        public List<ActorShort> ActorList { get; set; }
        public FullCastData FullCast { get; set; }
        public string Genres { set; get; }
        public List<KeyValueItem> GenreList { get; set; }
        public string Companies { get; set; }
        public List<CompanyShort> CompanyList { get; set; }
        public string Countries { set; get; }
        public List<KeyValueItem> CountryList { set; get; }
        public string Languages { set; get; }
        public List<KeyValueItem> LanguageList { set; get; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingVotes { get; set; }
        public string MetacriticRating { set; get; }
        public RatingData Ratings { set; get; }
        public WikipediaData Wikipedia { set; get; }
        public PosterData Posters { get; set; }
        public ImageData Images { get; set; }
        public TrailerData Trailer { get; set; }
        public BoxOfficeShort BoxOffice { get; set; }
        public string Tagline { get; set; }
        public string Keywords { get; set; }
        public List<string> KeywordList { get; set; }
        public List<SimilarShort> Similars { get; set; }
        public TvSeriesInfo TvSeriesInfo { get; set; }
        public TvEpisodeInfo TvEpisodeInfo { get; set; }
        public string ErrorMessage { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }


    public class PosterDataItem
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public double AspectRatio { get; set; }
        public string Language { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class TvSeriesInfo
    {
        public TvSeriesInfo()
        {
            CreatorList = new List<StarShort>();
            Seasons = new List<string>();
            Creators = YearEnd = string.Empty;
        }

        public string YearEnd { set; get; }
        public string Creators { set; get; }
        public List<StarShort> CreatorList { get; set; }
        public List<string> Seasons { get; set; }
    }

    public class TvEpisodeInfo
    {
        public string SeriesId { get; set; }
        public string SeriesTitle { get; set; }
        public string SeriesFullTitle { get; set; }
        public string SeriesYear { get; set; }
        public string SeriesYearEnd { get; set; }
        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }
        public string PreviousEpisodeId { get; set; }
        public string NextEpisodeId { get; set; }
    }

    public class SimilarShort
    {
        public SimilarShort()
        {
            Id = Title = Image = IMDbRating = string.Empty;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string IMDbRating { get; set; }
    }

    public class StarShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class BoxOfficeShort
    {
        public BoxOfficeShort()
        {
            Budget = OpeningWeekendUSA = GrossUSA = CumulativeWorldwideGross = string.Empty;
        }

        public string Budget { get; set; }
        public string OpeningWeekendUSA { get; set; }
        public string GrossUSA { get; set; }
        public string CumulativeWorldwideGross { get; set; }
    }

    public class CompanyShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}