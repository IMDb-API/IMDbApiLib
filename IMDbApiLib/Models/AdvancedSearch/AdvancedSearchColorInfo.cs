using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchColorInfo
{
    [Display(Name = "Color", Description = "color")]
    Color = 1,

    [Display(Name = "Black & White", Description = "black_and_white")]
    BlackAndWhite = 2,

    [Display(Name = "Colorized", Description = "colorized")]
    Colorized = 4,

    [Display(Name = "ACES", Description = "aces")]
    Aces = 8,
}