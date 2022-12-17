using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class NewMovieData
    {
        public NewMovieData()
        {
            ErrorMessage = string.Empty;
            Items = new List<NewMovieDataDetail>();
        }

        public NewMovieData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = new List<NewMovieDataDetail>();
        }

        public List<NewMovieDataDetail> Items { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class NewMovieDataDetail
    {
        public NewMovieDataDetail()
        {
            GenreList = new List<KeyValueItem>();
            DirectorList = new List<StarShort>();
            StarList = new List<StarShort>();
        }

        public string Id { get; set; }
        public string Title { set; get; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string ReleaseState { set; get; }
        public string Image { get; set; }
        public string RuntimeMins { set; get; }
        public string RuntimeStr { set; get; }
        public string Plot { set; get; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingCount { get; set; }
        public string MetacriticRating { set; get; }
        public string Genres { set; get; }
        public List<KeyValueItem> GenreList { get; set; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public string Stars { set; get; }
        public List<StarShort> StarList { get; set; }
    }
}