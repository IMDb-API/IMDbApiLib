using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class UserRatingData
    {
        public UserRatingData()
        {
            ErrorMessage = string.Empty;
            Ratings = new List<UserRatingDataDetail>();
        }

        public UserRatingData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
            Ratings = null;
            DemographicAll = null;
            DemographicMales = null;
            DemographicFemales = null;
            Top1000Voters = null;
            USUsers = null;
            NonUSUsers = null;
        }

        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string TotalRating { get; set; }
        public string TotalRatingVotes { get; set; }
        public List<UserRatingDataDetail> Ratings { get; set; }

        public UserRatingDataDemographic DemographicAll { get; set; }
        public UserRatingDataDemographic DemographicMales { get; set; }
        public UserRatingDataDemographic DemographicFemales { get; set; }
        public UserRatingDataDemographicDetail Top1000Voters { get; set; }
        public UserRatingDataDemographicDetail USUsers { get; set; }
        public UserRatingDataDemographicDetail NonUSUsers { get; set; }
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