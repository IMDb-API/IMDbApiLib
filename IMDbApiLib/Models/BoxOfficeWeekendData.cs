using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class BoxOfficeWeekendData
    {
        public BoxOfficeWeekendData()
        {
            ErrorMessage = string.Empty;
            Items = new List<BoxOfficeWeekendDataDetail>();
        }

        public BoxOfficeWeekendData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = new List<BoxOfficeWeekendDataDetail>();
        }

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