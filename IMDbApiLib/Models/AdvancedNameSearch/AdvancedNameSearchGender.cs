using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

[Flags]
public enum AdvancedNameSearchGender
{
    [Display(Name = "Male", Description = "male")]
    Male = 1,

    [Display(Name = "Female", Description = "female")]
    Female = 2,

    [Display(Name = "Non-binary", Description = "non_binary")]
    NonBinary = 4,

    [Display(Name = "Other", Description = "other")]
    Other = 8,
}