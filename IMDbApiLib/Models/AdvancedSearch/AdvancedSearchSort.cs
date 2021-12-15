using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    public enum AdvancedSearchSort
    {
        [Display(Name = "Popularity Ascending")]
        [Description("moviemeter,asc")]
        Popularity_Ascending,
        [Display(Name = "Popularity Descending")]
        [Description("moviemeter,desc")]
        Popularity_Descending,
        [Display(Name = "A-Z Ascending")]
        [Description("alpha,asc")]
        A_Z_Ascending,
        [Display(Name = "A-Z Descending")]
        [Description("alpha,desc")]
        A_Z_Descending,
        [Display(Name = "User Rating Ascending")]
        [Description("user_rating,asc")]
        User_Rating_Ascending,
        [Display(Name = "User Rating Descending")]
        [Description("user_rating,desc")]
        User_Rating_Descending,
        [Display(Name = "Num Votes Ascending")]
        [Description("num_votes,asc")]
        Num_Votes_Ascending,
        [Display(Name = "Num Votes Descending")]
        [Description("num_votes,desc")]
        Num_Votes_Descending,
        [Display(Name = "US Box Office Ascending")]
        [Description("boxoffice_gross_us,asc")]
        US_Box_Office_Ascending,
        [Display(Name = "US Box Office Descending")]
        [Description("boxoffice_gross_us,desc")]
        US_Box_Office_Descending,
        [Display(Name = "Runtime Ascending")]
        [Description("runtime,asc")]
        Runtime_Ascending,
        [Display(Name = "Runtime Descending")]
        [Description("runtime,desc")]
        Runtime_Descending,
        [Display(Name = "Year Ascending")]
        [Description("year,asc")]
        Year_Ascending,
        [Display(Name = "Year Descending")]
        [Description("year,desc")]
        Year_Descending,
        [Display(Name = "Release Date Ascending")]
        [Description("release_date,asc")]
        Release_Date_Ascending,
        [Display(Name = "Release Date Descending")]
        [Description("release_date,desc")]
        Release_Date_Descending,
        //[Display(Name = "Your rating (High to Low)")]
        //[Description("my_ratings,desc")]
        //Your_rating_High_to_Low,
        //[Display(Name = "Your rating (Low to High)")]
        //[Description("my_ratings,asc")]
        //Your_rating_Low_to_High,
        //[Display(Name = "Date of your rating (New to Old)")]
        //[Description("your_rating_date,desc")]
        //Date_of_your_rating_New_to_Old,
        //[Display(Name = "Date of your rating (Old to New)")]
        //[Description("your_rating_date,asc")]
        //Date_of_your_rating_Old_to_New
    }
}