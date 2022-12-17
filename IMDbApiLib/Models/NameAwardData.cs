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
            OutcomeItems = new List<NameAwardOutcome>();
        }

        public string EventTitle { get; set; }
        public List<NameAwardOutcome> OutcomeItems { get; set; }
    }

    public class NameAwardOutcome
    {
        public NameAwardOutcome()
        {
            OutcomeDetails = new List<NameAwardOutcomeDetail>();
        }

        public string OutcomeYear { get; set; }
        public string OutcomeTitle { get; set; }
        public string OutcomeCategory { get; set; }
        public List<NameAwardOutcomeDetail> OutcomeDetails { get; set; }
    }

    public class NameAwardOutcomeDetail
    {
        public string PlainText { get; set; }
        public string Html { get; set; }
    }
}