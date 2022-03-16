using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class UserRatingData
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }

        public string TotalRating { get; set; }
        public string TotalRatingVotes { get; set; }

        public List<UserRatingDataDetail> Ratings { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class UserRatingDataDetail
    {
        public string Rating { get; set; }
        public string Percent { get; set; }
        public string Votes { get; set; }
    }

    public class UserRatingDataDemographicDetail
    {
        public string Rating { get; set; }
        public string Votes { get; set; }
    }

    public class UserRatingDataDemographic
    {
        public UserRatingDataDemographicDetail AllAges { get; set; }
        public UserRatingDataDemographicDetail AgesUnder18 { get; set; }
        public UserRatingDataDemographicDetail Ages18To29 { get; set; }
        public UserRatingDataDemographicDetail Ages30To44 { get; set; }
        public UserRatingDataDemographicDetail AgesOver45 { get; set; }
    }
}