using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMDbApiLib.Models
{
    [Flags]
    public enum AdvancedSearchTitleGroup
    {
        [Display(Name = "Top 100")]
        [Description("top_100")]
        Top_100 = 1,
        [Display(Name = "Top 250")]
        [Description("top_250")]
        Top_250 = 2,
        [Display(Name = "Top 1000")]
        [Description("top_1000")]
        Top_1000 = 4,
        [Display(Name = "Bottom 100")]
        [Description("bottom_100")]
        Bottom_100 = 8,
        [Display(Name = "Bottom 250")]
        [Description("bottom_250")]
        Bottom_250 = 16,
        [Display(Name = "Bottom 1000")]
        [Description("bottom_1000")]
        Bottom_1000 = 32,
        [Display(Name = "Oscar-Winner")]
        [Description("oscar_winner")]
        Oscar_Winner = 64,
        [Display(Name = "Emmy-Winner")]
        [Description("emmy_winner")]
        Emmy_Winner = 128,
        [Display(Name = "Golden Globe-Winner")]
        [Description("golden_globe_winner")]
        Golden_Globe_Winner = 256,
        [Display(Name = "Oscar-Nominee")]
        [Description("oscar_nominee")]
        Oscar_Nominee = 512,
        [Display(Name = "Emmy-Nominee")]
        [Description("emmy_nominee")]
        Emmy_Nominee = 1024,
        [Display(Name = "Golden Globe-Nominee")]
        [Description("golden_globe_nominee")]
        Golden_Globe_Nominee = 2048,
        [Display(Name = "Best Picture-Winner")]
        [Description("best_picture_winner")]
        Best_Picture_Winner = 4096,
        [Display(Name = "Best Director-Winner")]
        [Description("best_director_winner")]
        Best_Director_Winner = 8192,
        [Display(Name = "Oscar Best Picture-Nominees")]
        [Description("oscar_best_picture_nominees")]
        Oscar_Best_Picture_Nominees = 16384,
        [Display(Name = "Oscar Best Director-Nominees")]
        [Description("oscar_best_director_nominees")]
        Oscar_Best_Director_Nominees = 32768,
        [Display(Name = "National Film Preservation Board-Winner")]
        [Description("national_film_preservation_board_winner")]
        National_Film_Preservation_Board_Winner = 65536,
        [Display(Name = "Razzie-Winner")]
        [Description("razzie_winner")]
        Razzie_Winner = 131072,
        [Display(Name = "Razzie-Nominee")]
        [Description("razzie_nomine")]
        Razzie_Nominee = 262144
    }
}