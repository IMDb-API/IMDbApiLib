using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class KeywordData
    {
        public KeywordData()
        {
            ErrorMessage = string.Empty;
            Items = new List<MovieShort>();
        }

        public KeywordData(string keyword, string errorMessage)
        {
            ErrorMessage = errorMessage;
            Items = null;
        }

        public string Keyword { get; set; }
        public List<MovieShort> Items { get; set; }
        public string ErrorMessage { get; set; }
    }
}