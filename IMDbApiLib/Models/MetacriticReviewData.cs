using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class MetacriticReviewData
    {
        public MetacriticReviewData()
        {
            ErrorMessage = string.Empty;
            Items = new List<MetacriticReviewDetail>();
        }

        public MetacriticReviewData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
        }

        public MetacriticReviewData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
            Items = null;
        }

        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public List<MetacriticReviewDetail> Items { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MetacriticReviewDetail
    {
        public MetacriticReviewDetail()
        {
            Publisher = Author = Link = Rate = Content = string.Empty;
        }

        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
        public string Rate { get; set; }
        public string Content { get; set; }
    }
}