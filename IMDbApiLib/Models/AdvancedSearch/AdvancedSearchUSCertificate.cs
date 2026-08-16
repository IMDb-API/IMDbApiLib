using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchUSCertificate
{
    [Display(Name = "G", Description = "US:G")]
    G = 1,

    [Display(Name = "PG", Description = "US:PG")]
    PG = 2,

    [Display(Name = "PG-13", Description = "US:PG-13")]
    PG13 = 4,

    [Display(Name = "R", Description = "US:R")]
    R = 8,

    [Display(Name = "NC-17", Description = "US:NC-17")]
    NC17 = 16,
}