using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class BoxOfficeAllTimeData
    {
        public List<BoxOfficeAllTimeDataDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class BoxOfficeAllTimeDataDetail
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string Title { get; set; }
        public string WorldwideLifetimeGross { get; set; }
        public string DomesticLifetimeGross { get; set; }
        public string Domestic { get; set; }
        public string ForeignLifetimeGross { get; set; }
        public string Foreign { get; set; }
        public string Year { get; set; }
    }
}
