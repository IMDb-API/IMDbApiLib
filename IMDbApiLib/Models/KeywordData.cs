using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class KeywordData
    {
        public string Keyword { get; set; }

        public List<MovieShort> Items { get; set; }

        public string ErrorMessage { get; set; }
    }
}
