using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class ImageData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public List<ImageDataDetail> Items { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class ImageDataDetail
    {
        public string Title { get; set; }
        public string Image { get; set; }
    }


}
