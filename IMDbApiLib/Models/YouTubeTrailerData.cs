namespace IMDbApiLib.Models
{
    public class YouTubeTrailerData
    {
        public YouTubeTrailerData()
        {
            ErrorMessage = string.Empty;
        }

        public YouTubeTrailerData(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public YouTubeTrailerData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
        }

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