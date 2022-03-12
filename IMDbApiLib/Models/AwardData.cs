using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class AwardData
    {
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
        public string EventTitle { get; set; }
        public string EventYear { get; set; }

        public List<AwardOutcome> OutcomeItems { get; set; }
    }

    public class AwardOutcome
    {
        public string OutcomeTitle { get; set; }
        public string OutcomeCategory { get; set; }

        public List<AwardOutcomeDetail> OutcomeDetails { get; set; }
    }

    public class AwardOutcomeDetail
    {
        public string PlainText { get; set; }
        public string Html { get; set; }
    }
}