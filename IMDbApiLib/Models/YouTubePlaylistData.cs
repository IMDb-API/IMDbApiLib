using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class YouTubePlaylistData
    {
        public string Title { get; set; }
        public string Auhtor { get; set; }
        public List<YouTubePlaylistDataItem> Videos { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class YouTubePlaylistDataItem
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string UploadDate { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
    }
}
