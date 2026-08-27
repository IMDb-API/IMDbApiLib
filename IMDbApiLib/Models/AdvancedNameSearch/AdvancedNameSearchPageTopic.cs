using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

[Flags]
public enum AdvancedNameSearchPageTopic
{
    [Display(Name = "Award Nominations", Description = "award-nominations")]
    AwardNominations = 1,

    [Display(Name = "Biography", Description = "biography")]
    Biography = 2,

    [Display(Name = "Birth Date", Description = "birth-date")]
    BirthDate = 4,

    [Display(Name = "Place of birth", Description = "birth-place")]
    BirthPlace = 8,

    [Display(Name = "Death Date", Description = "death-date")]
    DeathDate = 16,

    [Display(Name = "Place of death", Description = "death-place")]
    DeathPlace = 32,

    [Display(Name = "Height info", Description = "height")]
    Height = 64,

    [Display(Name = "Quotes", Description = "quotes")]
    Quotes = 128,

    [Display(Name = "Trivia", Description = "trivia")]
    Trivia = 256,
}