using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class BoxOfficeWeekendData
    {
        public List<BoxOfficeWeekendDataDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class BoxOfficeWeekendDataDetail
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string Title { set; get; }
        public string Image { get; set; }
        public string Weekend { get; set; }
        public string Gross { get; set; }
        public string Weeks { get; set; }
    }
}
