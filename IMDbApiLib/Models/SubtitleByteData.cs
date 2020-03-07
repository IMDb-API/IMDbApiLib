namespace IMDbApiLib.Models
{
    public class SubtitleByteData
    {
        public string Language { get; set; }

        public string Id { get; set; }
        public string Rate { get; set; } // none, good, bad
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Comment { get; set; }

        public byte[] Bytes { get; set; }
        public string UploadDate { get; set; }
        public string Downloads { get; set; }
        public string ReleaseType { get; set; }

        public string ErrorMessage { get; set; }
    }

}
