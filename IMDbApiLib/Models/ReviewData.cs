using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class ReviewData
    {
        public ReviewData()
        {
            ErrorMessage = "";
            Items = new List<ReviewDetail>();
        }

        public ReviewData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
        }

        public ReviewData(string id, string errorMessage)
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

        public List<ReviewDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class ReviewDetail
    {
        public ReviewDetail()
        {
            Username = UserUrl = ReviewLink = Date = Rate = Helpful = Title = Content = string.Empty;
        }

        public string Username { get; set; }
        public string UserUrl { get; set; }
        public string ReviewLink { get; set; }
        public bool WarningSpoilers { get; set; }
        public string Date { get; set; }
        public string Rate { get; set; }
        public string Helpful { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
