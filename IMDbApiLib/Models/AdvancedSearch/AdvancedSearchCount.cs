using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    public enum AdvancedSearchCount
    {
        [Display(Name = "50")]
        [Description("50")]
        Fifty = 50,
        [Display(Name = "100")]
        [Description("100")]
        Hundred = 100,
        [Display(Name = "250")]
        [Description("250")]
        Two_Hundred_and_Fifty = 250
    }
}