using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchInstantWatchOptions
{
    [Display(Name = "US Prime Video (Free)", Description = "US/today/Amazon/subs")]
    USPrimeVideoFree = 1,

    [Display(Name = "UK Prime Video (Free)", Description = "GB/today/Amazon/subs")]
    UKPrimeVideoFree = 2,

    [Display(Name = "DE Prime Video (Free)", Description = "DE/today/Amazon/subs")]
    DEPrimeVideoFree = 4,

    [Display(Name = "US Prime Video (Rent or Buy)", Description = "US/today/Amazon/paid")]
    USPrimeVideoRentOrBuy = 8,

    [Display(Name = "UK Prime Video (Rent or Buy)", Description = "GB/today/Amazon/paid")]
    UKPrimeVideoRentOrBuy = 16,

    [Display(Name = "DE Prime Video (Rent or Buy)", Description = "DE/today/Amazon/paid")]
    DEPrimeVideoRentOrBuy = 32,
}