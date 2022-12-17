using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class PosterData
    {
        public PosterData()
        {
            ErrorMessage = string.Empty;
            Posters = new List<PosterDataItem>();
            Backdrops = new List<PosterDataItem>();
        }

        public PosterData(string id, string errorMessage)
        {
            ErrorMessage = errorMessage;
            IMDbId = id;
            Posters = new List<PosterDataItem>();
            Backdrops = new List<PosterDataItem>();
        }

        public PosterData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Posters = new List<PosterDataItem>();
            Backdrops = new List<PosterDataItem>();
        }

        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { set; get; }
        public string Year { set; get; }
        public List<PosterDataItem> Posters { get; set; }
        public List<PosterDataItem> Backdrops { get; set; }
        public string ErrorMessage { get; set; }
    }
}