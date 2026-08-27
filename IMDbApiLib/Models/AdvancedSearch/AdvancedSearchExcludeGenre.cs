using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchExcludeGenre
{
    [Display(Name = "Documentary", Description = "documentary")]
    Documentary = 1,

    [Display(Name = "Short", Description = "short")]
    Short = 2,
}