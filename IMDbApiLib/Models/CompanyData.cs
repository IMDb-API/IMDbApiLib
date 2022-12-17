using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class CompanyData
    {
        public CompanyData()
        {
            ErrorMessage = string.Empty;
            Items = new List<MovieShort>();
        }

        public CompanyData(string errorMessage)
        {
            Items = null;
            ErrorMessage = errorMessage;
        }

        public CompanyData(string id, string errorMessage)
        {
            Id = id;
            Items = null;
            ErrorMessage = errorMessage;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public List<MovieShort> Items { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MovieShort
    {
        public string Id { get; set; }
        public string Title { set; get; }
        public string Year { set; get; }
        public string Image { get; set; }
        public string IMDbRating { get; set; }
    }
}