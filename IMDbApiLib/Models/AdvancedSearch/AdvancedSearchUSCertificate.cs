using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchUSCertificate
    {
        [Display(Name = "G")]
        [Description("US%3AG")]
        G = 1,
        [Display(Name = "PG")]
        [Description("US%3APG")]
        PG = 2,
        [Display(Name = "PG-13")]
        [Description("US%3APG-13")]
        PG_13 = 4,
        [Display(Name = "R")]
        [Description("US%3AR")]
        R = 8,
        [Display(Name = "NC-17")]
        [Description("US%3ANC-17")]
        NC_17 = 16
    }
}