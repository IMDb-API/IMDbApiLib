namespace IMDbApiLib.Models
{
    public class YouTubeTrailerData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string VideoId { get; set; }
        public string VideoUrl { get; set; }

        public string ErrorMessage { get; set; }
    }
}
