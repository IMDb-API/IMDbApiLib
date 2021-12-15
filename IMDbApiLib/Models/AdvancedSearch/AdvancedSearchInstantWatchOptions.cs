using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchInstantWatchOptions
    {
        [Display(Name = "US Prime Video ($0.00 with Membership)")]
        [Description("2Fsubs")]
        US_Prime_Video_0USD_with_Membership = 1,
        [Display(Name = "US Prime Video (Rent or Buy)")]
        [Description("2Fpaid")]
        US_Prime_Video_Rent_or_Buy = 2,
        [Display(Name = "UK Prime Video ($0.00 with Membership)")]
        [Description("2Fsubs")]
        UK_Prime_Video_0USD_with_Membership = 4,
        [Display(Name = "UK Prime Video (Rent or Buy)")]
        [Description("2Fpaid")]
        UK_Prime_Video_Rent_or_Buy = 8,
        [Display(Name = "DE Prime Video ($0.00 with Membership)")]
        [Description("2Fsubs")]
        DE_Prime_Video_0USD_with_Membership = 16,
        [Display(Name = "DE Prime Video (Rent or Buy)")]
        [Description("2Fpai")]
        DE_Prime_Video_Rent_or_Buy = 32
    }
}