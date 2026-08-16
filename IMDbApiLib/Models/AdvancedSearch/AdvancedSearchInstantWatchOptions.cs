using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models;

public enum AdvancedSearchInstantWatchOptions
{
    [Display(Name = "Freevee (US)", Description = "US%2FIMDbTV")]
    FreeveeUS = 1,

    [Display(Name = "US Prime Video (Free)", Description = "US%2Ftoday%2FAmazon%2Fsubs")]
    USPrimeVideoFree = 2,

    [Display(Name = "UK Prime Video (Free)", Description = "GB%2Ftoday%2FAmazon%2Fsubs")]
    UKPrimeVideoFree = 4,

    [Display(Name = "DE Prime Video (Free)", Description = "DE%2Ftoday%2FAmazon%2Fsubs")]
    DEPrimeVideoFree = 8,

    [Display(Name = "US Prime Video (Rent or Buy)", Description = "US%2Ftoday%2FAmazon%2Fpaid")]
    USPrimeVideoRentOrBuy = 16,

    [Display(Name = "UK Prime Video (Rent or Buy)", Description = "GB%2Ftoday%2FAmazon%2Fpaid")]
    UKPrimeVideoRentOrBuy = 32,

    [Display(Name = "DE Prime Video (Rent or Buy)", Description = "DE%2Ftoday%2FAmazon%2Fpaid")]
    DEPrimeVideoRentOrBuy = 64,
}