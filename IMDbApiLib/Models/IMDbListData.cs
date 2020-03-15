using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class IMDbListData
    {
        public string Title { get; set; }
        public string By { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Description { get; set; }

        public List<IMDbListDataDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class IMDbListDataDetail
    {
        public string Id { get; set; }
        public string Index { get; set; }
        public string Title { set; get; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string Image { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingCount { get; set; }
        public string Description { get; set; }
    }
}
