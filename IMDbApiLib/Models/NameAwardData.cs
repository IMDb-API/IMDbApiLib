using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class NameAwardData
    {
        public NameAwardData()
        {
            ErrorMessage = string.Empty;
            Items = new List<NameAwardEvent>();
        }

        public NameAwardData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
        }

        public NameAwardData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
            Items = null;
        }

        public string IMDbId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<NameAwardEvent> Items { get; set; }
        public string NameAwardsHtml { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class NameAwardEvent
    {
        public NameAwardEvent()
        {
            NameAwardEventDetails = new List<NameAwardEventDetail>();
        }

        public string EventTitle { get; set; }
        public List<NameAwardEventDetail> NameAwardEventDetails { get; set; }
    }

    public class NameAwardEventDetail
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string For { get; set; }
        public string Description { get; set; }
    }
}