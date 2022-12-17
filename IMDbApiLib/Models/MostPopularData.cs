using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class MostPopularData
    {
        public MostPopularData()
        {
            ErrorMessage = string.Empty;
            Items = new List<MostPopularDataDetail>();
        }

        public MostPopularData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = new List<MostPopularDataDetail>();
        }

        public List<MostPopularDataDetail> Items { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MostPopularDataDetail
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string RankUpDown { get; set; }
        public string Title { set; get; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string Image { get; set; }
        public string Crew { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingCount { get; set; }
    }
}