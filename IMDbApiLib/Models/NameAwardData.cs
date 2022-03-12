using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class NameAwardData
    {
        public string IMDbId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public List<NameAwardEvent> Items { get; set; }
        public string NameAwardsHtml { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class NameAwardEvent
    {
        public string EventTitle { get; set; }

        public List<NameAwardOutcome> OutcomeItems { get; set; }
    }

    public class NameAwardOutcome
    {
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