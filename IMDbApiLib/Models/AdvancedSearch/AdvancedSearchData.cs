using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    public class AdvancedSearchData
    {
        public string QueryString { get; set; }
        public List<AdvancedSearchResult> Results { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AdvancedSearchResult
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Runtime Str")]
        public string RuntimeStr { set; get; }

        [Display(Name = "Genres")]
        public string Genres { set; get; }

        [Display(Name = "Genre List")]
        public List<KeyValueItem> GenreList { get; set; }

        [Display(Name = "Content Rating")]
        public string ContentRating { get; set; }

        [Display(Name = "IMDb Rating")]
        public string IMDbRating { get; set; }

        [Display(Name = "IMDb Rating Votes")]
        public string IMDbRatingVotes { get; set; }

        [Display(Name = "Metacritic Rating")]
        public string MetacriticRating { set; get; }

        [Display(Name = "Plot")]
        public string Plot { set; get; }

        [Display(Name = "Stars")]
        public string Stars { set; get; }

        [Display(Name = "Star List")]
        public List<StarShort> StarList { get; set; }
    }
}