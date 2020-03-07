using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class YouTubeData
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string UploadDate { get; set; }
        public string Image { get; set; }
        public List<YouTubeDataItem> Videos { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class YouTubeDataItem
    {
        public string Quality { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public string Url { get; set; }
    }
}
