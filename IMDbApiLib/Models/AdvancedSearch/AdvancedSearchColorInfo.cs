using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchColorInfo
    {
        [Display(Name = "Color")]
        [Description("color")]
        Color = 1,
        [Display(Name = "Black and White")]
        [Description("black_and_white")]
        Black_and_White = 2,
        [Display(Name = "Colorized")]
        [Description("colorized")]
        Colorized = 4,
        [Display(Name = "Aces")]
        [Description("aces")]
        Aces = 8
    }
}