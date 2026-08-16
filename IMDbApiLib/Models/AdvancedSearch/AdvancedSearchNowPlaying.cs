using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchNowPlaying
{
    //[Display(Name = "Show all titles", Description = "")]
    //ShowAllTitles = 1,

    [Display(Name = "In theaters near you", Description = "restrict")]
    InTheatersNearYou = 2,

    [Display(Name = "In favorite theaters", Description = "favorite-theaters")]
    InFavoriteTheaters = 4,

    [Display(Name = "In theaters with online ticketing (US only)", Description = "online-ticketing")]
    InTheatersWithOnlineTicketingUSOnly = 8,
}