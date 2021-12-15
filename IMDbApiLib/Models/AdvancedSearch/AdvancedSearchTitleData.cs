using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchTitleData
    {
        [Display(Name = "Alternate Versions")]
        [Description("versions")]
        Alternate_Versions = 1,
        [Display(Name = "Awards")]
        [Description("awards")]
        Awards = 2,
        [Display(Name = "Business Info")]
        [Description("info")]
        Business_Info = 4,
        [Display(Name = "Crazy Credits")]
        [Description("credits")]
        Crazy_Credits = 8,
        [Display(Name = "Goofs")]
        [Description("goofs")]
        Goofs = 16,
        [Display(Name = "Locations")]
        [Description("locations")]
        Locations = 32,
        [Display(Name = "Plot")]
        [Description("plot")]
        Plot = 64,
        [Display(Name = "Quotes")]
        [Description("quotes")]
        Quotes = 128,
        [Display(Name = "Soundtracks")]
        [Description("soundtracks")]
        Soundtracks = 256,
        [Display(Name = "Technical")]
        [Description("technical")]
        Technical = 512,
        [Display(Name = "Trivia")]
        [Description("trivia")]
        Trivia = 1024,
        [Display(Name = "X-Ray")]
        [Description("ra")]
        X_Ray = 2048
    }
}