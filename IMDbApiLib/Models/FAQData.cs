using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class FAQData
    {
        public FAQData()
        {
            ErrorMessage = "";
            Items = new List<FAQDetail>();
            SpoilerItems = new List<FAQDetail>();
        }

        public FAQData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
            SpoilerItems = null;
        }

        public FAQData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
            Items = null;
            SpoilerItems = null;
        }

        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public List<FAQDetail> Items { get; set; }
        public List<FAQDetail> SpoilerItems { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class FAQDetail
    {
        public FAQDetail()
        {
            Question = Answer = string.Empty;
        }

        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
