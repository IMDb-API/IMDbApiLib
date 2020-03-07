using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class SubtitleData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public List<SubtitleDataDetail> Subtitles { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class SubtitleDataDetail
    {
        public int? SeasonNumber { get; set; }
        public string Id { get; set; }
        public string Rate { get; set; } // none, good, bad
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Comment { get; set; }
        public string Link { get; set; }
    }


}
