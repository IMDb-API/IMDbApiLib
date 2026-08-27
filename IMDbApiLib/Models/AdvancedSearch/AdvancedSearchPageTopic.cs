using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchPageTopic
{
    [Display(Name = "Alternate Versions", Description = "alternate-versions")]
    AlternateVersions = 1,

    [Display(Name = "Awards", Description = "awards")]
    Awards = 2,

    [Display(Name = "Business Info", Description = "business-info")]
    BusinessInfo = 4,

    [Display(Name = "Crazy Credits", Description = "crazy-credits")]
    CrazyCredits = 8,

    [Display(Name = "Goofs", Description = "goofs")]
    Goofs = 16,

    [Display(Name = "Locations", Description = "locations")]
    Locations = 32,

    [Display(Name = "Plot", Description = "plot")]
    Plot = 64,

    [Display(Name = "Quotes", Description = "quotes")]
    Quotes = 128,

    [Display(Name = "Soundtracks", Description = "soundtracks")]
    Soundtracks = 256,

    [Display(Name = "Tech specs", Description = "technical")]
    Technical = 512,

    [Display(Name = "Trivia", Description = "trivia")]
    Trivia = 1024,
}