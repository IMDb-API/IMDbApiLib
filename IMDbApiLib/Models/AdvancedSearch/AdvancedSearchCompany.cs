using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchCompany
    {
        [Display(Name = "20th Century Fox")]
        [Description("fox")]
        Twentieth_Century_Fox = 1,
        [Display(Name = "Sony")]
        [Description("sony")]
        Sony = 2,
        [Display(Name = "DreamWorks")]
        [Description("dreamworks")]
        DreamWorks = 4,
        [Display(Name = "MGM")]
        [Description("mgm")]
        MGM = 8,
        [Display(Name = "Paramount")]
        [Description("paramount")]
        Paramount = 16,
        [Display(Name = "Universal")]
        [Description("universal")]
        Universal = 32,
        [Display(Name = "Walt Disney")]
        [Description("disney")]
        Walt_Disney = 64,
        [Display(Name = "Warner Bross.")]
        [Description("warne")]
        Warner_Bross = 128
    }
}