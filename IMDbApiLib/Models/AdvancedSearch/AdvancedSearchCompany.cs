using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchCompany
{
    [Display(Name = "20th Century Fox (US)", Description = "fox")]
    TwentiethCenturyFox = 1,

    [Display(Name = "DreamWorks (US)", Description = "dreamworks")]
    DreamWorks = 2,

    [Display(Name = "MGM (US)", Description = "mgm")]
    MGM = 4,

    [Display(Name = "Paramount (US)", Description = "paramount")]
    Paramount = 8,

    [Display(Name = "Sony (US)", Description = "sony")]
    Sony = 16,

    [Display(Name = "Universal (US)", Description = "universal")]
    Universal = 32,

    [Display(Name = "Walt Disney (US)", Description = "disney")]
    WaltDisney = 64,

    [Display(Name = "Warner Bros. (US)", Description = "warner")]
    WarnerBros = 128,
}