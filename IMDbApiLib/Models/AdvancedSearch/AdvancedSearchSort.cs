using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchSort
{
    [Display(Name = "Popularity Ascending", Description = "moviemeter,asc")]
    PopularityAscending,

    [Display(Name = "Popularity Descending", Description = "moviemeter,desc")]
    PopularityDescending,

    [Display(Name = "A-Z Ascending", Description = "alpha,asc")]
    AZAscending,

    [Display(Name = "A-Z Descending", Description = "alpha,desc")]
    AZDescending,

    [Display(Name = "User Rating Ascending", Description = "user_rating,asc")]
    UserRatingAscending,

    [Display(Name = "User Rating Descending", Description = "user_rating,desc")]
    UserRatingDescending,

    [Display(Name = "Num Votes Ascending", Description = "num_votes,asc")]
    NumVotesAscending,

    [Display(Name = "Num Votes Descending", Description = "num_votes,desc")]
    NumVotesDescending,

    [Display(Name = "US Box Office Ascending", Description = "boxoffice_gross_us,asc")]
    USBoxOfficeAscending,

    [Display(Name = "US Box Office Descending", Description = "boxoffice_gross_us,desc")]
    USBoxOfficeDescending,

    [Display(Name = "Runtime Ascending", Description = "runtime,asc")]
    RuntimeAscending,

    [Display(Name = "Runtime Descending", Description = "runtime,desc")]
    RuntimeDescending,

    [Display(Name = "Year Ascending", Description = "year,asc")]
    YearAscending,

    [Display(Name = "Year Descending", Description = "year,desc")]
    YearDescending,

    [Display(Name = "Release Date Ascending", Description = "release_date,asc")]
    ReleaseDateAscending,

    [Display(Name = "Release Date Descending", Description = "release_date,desc")]
    ReleaseDateDescending,
}