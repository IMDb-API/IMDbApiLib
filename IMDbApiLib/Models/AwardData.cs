using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class AwardData
    {
        public AwardData()
        {
            ErrorMessage = string.Empty;
            Items = new List<AwardEvent>();
        }

        public AwardData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
        }

        public AwardData(string id, string errorMessage)
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

        public string Description { get; set; }
        public List<AwardEvent> Items { get; set; }
        public string AwardsHtml { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class AwardEvent
    {
        public AwardEvent()
        {
            AwardEventDetails = new List<AwardEventDetail>();
        }

        public string EventTitle { get; set; }

        public List<AwardEventDetail> AwardEventDetails { get; set; }
    }

    public class AwardEventDetail
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string For { get; set; }
        public string Description { get; set; }
    }
}