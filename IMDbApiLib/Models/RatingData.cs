﻿namespace IMDbApiLib.Models
{
    public class RatingData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string IMDb { get; set; }
        public string Metacritic { get; set; }
        public string TheMovieDb { get; set; }
        public string RottenTomatoes { get; set; }
        public string FilmAffinity { get; set; }

        public string ErrorMessage { get; set; }
    }
}
