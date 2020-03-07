using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class SeasonEpisodeData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public List<EpisodeShortDetail> Episodes { get; set; }

        public string ErrorMessage { get; set; }

    }

    public class EpisodeShortDetail
    {
        public string Id { get; set; }
        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Year { set; get; }
        public string Released { set; get; }
        public string Plot { set; get; }
        public string RatingValue { get; set; }
        public string RatingCount { get; set; }

    }
}
